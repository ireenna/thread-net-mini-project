import { Injectable, OnDestroy } from '@angular/core';
import { DialogType } from '../models/common/auth-dialog-type';
import { AuthDialogComponent } from '../components/auth-dialog/auth-dialog.component';
import { User } from '../models/user';
import { MatDialog } from '@angular/material/dialog';
import { map, takeUntil } from 'rxjs/operators';
import { Subscription, Subject } from 'rxjs';
import { ReactionDialogComponent } from '../components/reaction-dialog/reaction-dialog.component';
import { Reaction } from '../models/reactions/reaction';

@Injectable({ providedIn: 'root' })
export class ReactionDialogService {
    private unsubscribe$ = new Subject<void>();

    public constructor(private dialog: MatDialog) {}

    public openReactionDialog(type: Reaction[]) {
        const dialog = this.dialog.open(ReactionDialogComponent, {
            data: { Reaction: type },
            minWidth: 300,
            autoFocus: true,
            backdropClass: 'dialog-backdrop',
            position: {
                top: '0'
            }
        });
    }
}
