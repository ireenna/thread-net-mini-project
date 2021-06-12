import { Component, OnInit, Inject, OnDestroy, Input } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DialogType } from '../../models/common/auth-dialog-type';
import { Subject } from 'rxjs';
import { AuthenticationService } from '../../services/auth.service';
import { takeUntil } from 'rxjs/operators';
import { SnackBarService } from '../../services/snack-bar.service';
import { User } from 'src/app/models/user';


@Component({
    templateUrl: './reaction-dialog.component.html',
    styleUrls: ['./reaction-dialog.component.sass']
})
export class ReactionDialogComponent implements OnInit {
    @Input() public likeUsers: User[];
    @Input() public dislikeUsers: User[];

    displayedColumns: string[] = ['userName'];

    constructor(
        private dialogRef: MatDialogRef<ReactionDialogComponent>,
        @Inject(MAT_DIALOG_DATA) public Reaction: any
    ) {}

    public ngOnInit() {
        this.likeUsers = this.Reaction.Reaction.filter(x => x.isLike === true).map(user => user.user);
        this.dislikeUsers = this.Reaction.Reaction.filter(x => x.isDislike === true).map(user => user.user);
    }

    public close() {
        this.dialogRef.close(false);
    }
}