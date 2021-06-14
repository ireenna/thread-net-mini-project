import { Component, Input, OnDestroy } from '@angular/core';
import { Post } from '../../models/post/post';
import { AuthenticationService } from '../../services/auth.service';
import { AuthDialogService } from '../../services/auth-dialog.service';
import { empty, Observable, Subject } from 'rxjs';
import { DialogType } from '../../models/common/auth-dialog-type';
import { LikeService } from '../../services/like.service';
import { NewComment } from '../../models/comment/new-comment';
import { CommentService } from '../../services/comment.service';
import { User } from '../../models/user';
import { Comment } from '../../models/comment/comment';
import { catchError, switchMap, takeUntil } from 'rxjs/operators';
import { SnackBarService } from '../../services/snack-bar.service';
import { PostService } from 'src/app/services/post.service';
import { EditPost } from 'src/app/models/post/edit-post';
import { Reaction } from 'src/app/models/reactions/reaction';
import { ReactionDialogService } from 'src/app/services/reaction-dialog.service';
import { ShareDialogService } from 'src/app/services/share-dialog.service';

@Component({
    selector: 'app-post',
    templateUrl: './post.component.html',
    styleUrls: ['./post.component.sass']
})
export class PostComponent implements OnDestroy {
    @Input() public post: Post;
    @Input() public currentUser: User;
    @Input() public editedPost: EditPost;
    public cachedBody: string;
    public showComments = false;
    public newComment = {} as NewComment;
    public postEditMode = false;
    public loading = false;
    public isDeleted = false;
    public users: User[] = [];
    public shownUsers = 3;
    public imageFile: File;

    private unsubscribe$ = new Subject<void>();

    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private likeService: LikeService,
        private commentService: CommentService,
        private snackBarService: SnackBarService,
        private postService: PostService,
        private reactionDialogService: ReactionDialogService,
        private shareDialogService: ShareDialogService
    ) {}

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public toggleComments() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe((user) => {
                    if (user) {
                        this.currentUser = user;
                        this.showComments = !this.showComments;
                    }
                });
            return;
        }

        this.showComments = !this.showComments;
    }

    public likePost() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.likeService.likePost(this.post, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((post) => (this.post = post));
            
            return;
        }

        this.likeService
            .likePost(this.post, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((post) => (this.post = post));

    
    }

    public dislikePost() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.likeService.dislikePost(this.post, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((post) => (this.post = post));

            return;
        }

        this.likeService
            .dislikePost(this.post, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((post) => (this.post = post));
    }
    public getLikes(){
        var filteredLikes = this.post.reactions.filter(reactions => reactions.isLike == true)
        var countLikes = filteredLikes.length;
        
        return countLikes;
    }
    public getDislikes(){
        var filteredDislikes = this.post.reactions.filter(reactions => reactions.isDislike == true)
        var countDislikes = filteredDislikes.length;
        return countDislikes;
    }
    public sendComment() {
        this.newComment.authorId = this.currentUser.id;
        this.newComment.postId = this.post.id;

        this.commentService
            .createComment(this.newComment)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    if (resp) {
                        this.post.comments = this.sortCommentArray(this.post.comments.concat(resp.body));
                        this.newComment.body = undefined;
                    }
                },
                (error) => this.snackBarService.showErrorMessage(error)
            );
    }

    public openAuthDialog() {
        this.authDialogService.openAuthDialog(DialogType.SignIn);
    }

    private catchErrorWrapper(obs: Observable<User>) {
        return obs.pipe(
            catchError(() => {
                this.openAuthDialog();
                return empty();
            })
        );
    }

    private sortCommentArray(array: Comment[]): Comment[] {
        return array.sort((a, b) => +new Date(b.createdAt) - +new Date(a.createdAt));
    }

    public toggleEditMode() {
        this.cachedBody = this.post.body;
        this.postEditMode = !this.postEditMode;
    }
    public cancelEditing() {
        this.post.body = this.cachedBody;
        this.toggleEditMode();
    }

    public saveEditedPost() {
        this.editedPost = {body:this.post.body};
        const postEditing = this.postService.updatePost(this.editedPost, this.post.id);
        this.loading = true;

        postEditing.pipe(takeUntil(this.unsubscribe$)).subscribe(
            (resp) => {
                this.post = resp.body;
                this.snackBarService.showUsualMessage('Successfully updated');
                this.loading = false;
            },
            (error) => this.snackBarService.showErrorMessage(error)
        );

        this.postEditMode = false;
    }
    public getUsersLikedPost(){
        this.users=[]
        this.post.reactions.filter(reactions => reactions.isLike == true).forEach(r => this.users.push(r.user))
        return this.users
    }
    public deletePost(){
        if(this.post.author.id === this.currentUser.id){
           this.postService.deletePost(this.post.id)
           .pipe(takeUntil(this.unsubscribe$))
           .subscribe(
                () => {
                    this.snackBarService.showUsualMessage('Successfully deleted');
                    this.isDeleted = true;
                },
                (error) => this.snackBarService.showErrorMessage(error)
            );
        }
    }
    public openLikedDialog() {
        this.reactionDialogService.openReactionDialog(this.post.reactions);
    }
    public handleFileInput(target: any) {
        alert(this.post.previewImage)
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';
            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            this.snackBarService.showErrorMessage(`Image can't be heavier than ~5MB`);
            target.value = '';
            return;
        }

        const reader = new FileReader();
        reader.addEventListener('load', () => (this.post.previewImage = reader.result as string));
        reader.readAsDataURL(this.imageFile);
        alert(this.post.previewImage)
    }
    public sharePost(){
        this.shareDialogService.openShareDialog(this.post, this.currentUser);
    }
}
