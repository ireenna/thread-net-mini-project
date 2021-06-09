import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { NewComment } from '../models/comment/new-comment';
import { Comment } from '../models/comment/comment';
import { NewReaction } from '../models/reactions/newReaction';
import { EditComment } from '../models/comment/edit-comment';

@Injectable({ providedIn: 'root' })
export class CommentService {
    public routePrefix = '/api/comments';

    constructor(private httpService: HttpInternalService) {}

    public createComment(post: NewComment) {
        return this.httpService.postFullRequest<Comment>(`${this.routePrefix}`, post);
    }
    public updateComment(comment: EditComment, id:number) {
        return this.httpService.putFullRequest<Comment>(`${this.routePrefix}/`+id, comment);
    }
    public likeComment(reaction: NewReaction) {
        return this.httpService.postFullRequest<Comment>(`${this.routePrefix}/like`, reaction);
    }
    public dislikeComment(reaction: NewReaction) {
        return this.httpService.postFullRequest<Comment>(`${this.routePrefix}/dislike`, reaction);
    }
}
