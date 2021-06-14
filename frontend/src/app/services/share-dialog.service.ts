import { Injectable, OnDestroy } from '@angular/core';
import { DialogType } from '../models/common/auth-dialog-type';
import { AuthDialogComponent } from '../components/auth-dialog/auth-dialog.component';
import { User } from '../models/user';
import { MatDialog } from '@angular/material/dialog';
import { map, takeUntil } from 'rxjs/operators';
import { AuthenticationService } from './auth.service';
import { Subscription, Subject } from 'rxjs';
import { Post } from '../models/post/post';
import { ShareDialogComponent } from '../components/share-dialog/share-dialog.component';
import { PostService } from './post.service';

@Injectable({ providedIn: 'root' })
export class ShareDialogService implements OnDestroy {
    private unsubscribe$ = new Subject<void>();

    public constructor(private dialog: MatDialog) {}

    public openShareDialog(post: Post, user: User) {
        const dialog = this.dialog.open(ShareDialogComponent, {
            data: { Post: post, User: user},
            minWidth: 300,
            autoFocus: true,
            backdropClass: 'dialog-backdrop',
            position: {
                top: '0'
            }
        });
    }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }
}
