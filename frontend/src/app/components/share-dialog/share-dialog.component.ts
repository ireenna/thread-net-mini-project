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
import { AuthDialogService } from 'src/app/services/auth-dialog.service';


@Component({
    templateUrl: './share-dialog.component.html',
    styleUrls: ['./share-dialog.component.sass']
})
export class ShareDialogComponent implements OnInit {
    @Input() public email: EmailSharePost = {email: "", user: null, post: null};
    public emailAddress: string

    constructor(
        private dialogRef: MatDialogRef<ShareDialogComponent>,
        @Inject(MAT_DIALOG_DATA) public data: {Post, User},
        private postService: PostService,
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private snackBarService: SnackBarService
    ) {}

    private unsubscribe$ = new Subject<void>();

    public ngOnInit() {
        this.email.post = this.data.Post;
        this.email.user = this.data.User;
    }
    
    public sendEmail(){
        this.email.email = this.emailAddress
        this.postService.sharePostByEmail(this.email)
        .pipe(takeUntil(this.unsubscribe$))
        .subscribe(
             () => {
                 this.snackBarService.showUsualMessage('Successfully shared');
                 this.close();
             },
             (error) => this.snackBarService.showErrorMessage(error)
         );
    }

    public close() {
        this.dialogRef.close(false);
    }
}