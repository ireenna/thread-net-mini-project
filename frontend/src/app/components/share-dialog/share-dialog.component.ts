import { Component, OnInit, Inject, OnDestroy, Input } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DialogType } from '../../models/common/auth-dialog-type';
import { AuthenticationService } from '../../services/auth.service';
import { catchError, switchMap, takeUntil } from 'rxjs/operators';
import { SnackBarService } from '../../services/snack-bar.service';
import { User } from 'src/app/models/user';
import { Post } from 'src/app/models/post/post';
import { EmailSharePost } from 'src/app/models/email/email-share-post';
import { PostService } from 'src/app/services/post.service';
import { empty, Observable, Subject } from 'rxjs';


@Component({
    templateUrl: './share-dialog.component.html',
    styleUrls: ['./share-dialog.component.sass']
})
export class ShareDialogComponent implements OnInit {
    @Input() public email: EmailSharePost = {email: "", user: null, post: null};
    public emailAddress: string
    authDialogService: any;

    constructor(
        private dialogRef: MatDialogRef<ShareDialogComponent>,
        @Inject(MAT_DIALOG_DATA) public data: {Post, User},
        private postService: PostService,
        private authService: AuthenticationService
    ) {}

    private unsubscribe$ = new Subject<void>();

    public ngOnInit() {
        this.email.post = this.data.Post;
        this.email.user = this.data.User;
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
    
    public sendEmail(){
        this.email.email = this.emailAddress
        if (!this.email.user) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => {
                        this.email.user = userResp;
                        return this.postService.sharePostByEmail(this.email)
                    }),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe();

            return;
        }

        this.postService
            .sharePostByEmail(this.email)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe();
    }

    public close() {
        this.dialogRef.close(false);
    }
}