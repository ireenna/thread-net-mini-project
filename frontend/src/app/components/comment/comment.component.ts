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

@Component({
    selector: 'app-comment',
    templateUrl: './comment.component.html',
    styleUrls: ['./comment.component.sass']
})
export class CommentComponent implements OnDestroy {
    @Input() public comment: Comment;
    @Input() public currentUser: User;
    private unsubscribe$ = new Subject<void>();
    
    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private likeService: LikeService,
        private commentService: CommentService,
        private snackBarService: SnackBarService
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
        public toggleComments() {
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
}
