import { Component, Input, OnDestroy } from '@angular/core';
import { Subject } from 'rxjs';
import { takeUntil, switchMap } from 'rxjs/operators';
import { DialogType } from 'src/app/models/common/auth-dialog-type';
import { User } from 'src/app/models/user';
import { AuthDialogService } from 'src/app/services/auth-dialog.service';
import { AuthenticationService } from 'src/app/services/auth.service';
import { CommentService } from 'src/app/services/comment.service';
import { LikeService } from 'src/app/services/like.service';
import { SnackBarService } from 'src/app/services/snack-bar.service';
import { Comment } from '../../models/comment/comment';
import { empty, Observable} from 'rxjs';
import { catchError} from 'rxjs/operators';
import { EditComment } from 'src/app/models/comment/edit-comment';
import { ReactionDialogService } from 'src/app/services/reaction-dialog.service';

@Component({
    selector: 'app-comment',
    templateUrl: './comment.component.html',
    styleUrls: ['./comment.component.sass']
})
export class CommentComponent implements OnDestroy {
    @Input() public comment: Comment;
    public currentUser: User;
    @Input() public editedComment: EditComment;
    public cachedCommentBody: string;

    private unsubscribe$ = new Subject<void>();
    public commentEditMode = false;
    public isDeleted = false;
    public users: User[]=[];
    public shownUsers = 3;
    
    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private likeService: LikeService,
        private commentService: CommentService,
        private snackBarService: SnackBarService,
        private reactionDialogService: ReactionDialogService
    ) {}
    
        public ngOnDestroy() {
            this.unsubscribe$.next();
            this.unsubscribe$.complete();
        }
        private catchErrorWrapper(obs: Observable<User>) {
            return obs.pipe(
                catchError(() => {
                    this.openAuthDialog();
                    return empty();
                })
            );
        }
        public openAuthDialog() {
            this.authDialogService.openAuthDialog(DialogType.SignIn);
        }
        public getCurrentUser() {
            if (!this.currentUser) {
                this.catchErrorWrapper(this.authService.getUser())
                    .pipe(takeUntil(this.unsubscribe$))
                    .subscribe((user) => {
                        if (user) {
                            this.currentUser = user;
                        }
                    });
                return;
            }
        }
        public getEditMode(authorName){
            if(!this.currentUser){
                this.getCurrentUser()
            }
            return authorName === this.currentUser.userName;
        }

        public getLikes(){
            var filteredLikes = this.comment.reactions.filter(reactions => reactions.isLike == true)
            var countLikes = filteredLikes.length;
            return countLikes;
        }
        public getDislikes(){
            var filteredLikes = this.comment.reactions.filter(reactions => reactions.isDislike == true)
            var countLikes = filteredLikes.length;
            return countLikes;
        }
        public likeComment() {
            if (!this.currentUser) {
                this.catchErrorWrapper(this.authService.getUser())
                    .pipe(
                        switchMap((userResp) => this.likeService.likeComment(this.comment, userResp)),
                        takeUntil(this.unsubscribe$)
                    )
                    .subscribe((comment) => (this.comment = comment));
    
                return;
            }
    
            this.likeService
                .likeComment(this.comment, this.currentUser)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe((comment) => (this.comment = comment));
        }
        public dislikeComment() {
            if (!this.currentUser) {
                this.catchErrorWrapper(this.authService.getUser())
                    .pipe(
                        switchMap((userResp) => this.likeService.dislikeComment(this.comment, userResp)),
                        takeUntil(this.unsubscribe$)
                    )
                    .subscribe((comment) => (this.comment = comment));
                
                return;
            }
    
            this.likeService
                .dislikeComment(this.comment, this.currentUser)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe((comment) => (this.comment = comment));
        }
        public toggleEditMode() {
            this.cachedCommentBody = this.comment.body;
            this.commentEditMode = !this.commentEditMode;
        }
        public cancelEditing(){
            this.comment.body = this.cachedCommentBody;
            this.toggleEditMode();
        }
    
        public saveEditedComment() {
            this.editedComment = {body:this.comment.body};
            const postEditing = this.commentService.updateComment(this.editedComment, this.comment.id);
            
            postEditing.pipe(takeUntil(this.unsubscribe$)).subscribe(
                (resp) => {
                    this.comment = resp.body;
                    this.snackBarService.showUsualMessage('Successfully updated');
                },
                (error) => this.snackBarService.showErrorMessage(error)
            );
    
            this.commentEditMode = false;
        }
        public getUsersLikedComment(){
            this.users=[]
            this.comment.reactions.filter(reactions => reactions.isLike == true).forEach(r => this.users.push(r.user))
            return this.users
        }
        public deleteComment(){
            if(this.comment.author.id === this.currentUser.id){
               this.commentService.deleteComment(this.comment.id)
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
            this.reactionDialogService.openReactionDialog(this.comment.reactions);
        }
}
