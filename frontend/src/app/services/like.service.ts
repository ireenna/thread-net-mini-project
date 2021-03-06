import { Injectable } from '@angular/core';
import { AuthenticationService } from './auth.service';
import { Post } from '../models/post/post';
import { NewReaction } from '../models/reactions/newReaction';
import { PostService } from './post.service';
import { User } from '../models/user';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs';
import { CommentService } from './comment.service';
import { Comment } from '../models/comment/comment';

@Injectable({ providedIn: 'root' })
export class LikeService {
    public constructor(private authService: AuthenticationService, private postService: PostService, private commentService: CommentService) {}

    public likePost(post: Post, currentUser: User) {
        const innerPost = post;

        const reaction: NewReaction = {
            entityId: innerPost.id,
            isLike: true,
            isDislike: false,
            userId: currentUser.id
        };

        // update current array instantly
        let hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);
        let disliked =innerPost.reactions.some((x) => x.user.id === currentUser.id && x.isDislike == true);
        if(disliked){
            innerPost.reactions = innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
            .concat({ isLike: true, isDislike:false, user: currentUser });
        } else {
            innerPost.reactions = hasReaction
                ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                : innerPost.reactions.concat({ isLike: true, isDislike:false, user: currentUser });
        }
        hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);

        return this.postService.likePost(reaction).pipe(
            map(() => innerPost),
            catchError(() => {
                // revert current array changes in case of any error
                if(disliked){
                    innerPost.reactions = innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                    .concat({ isLike: true, isDislike:false, user: currentUser });
                } else {
                    innerPost.reactions = hasReaction
                        ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                        : innerPost.reactions.concat({ isLike: true, isDislike:false, user: currentUser });
                }
                return of(innerPost);
            })
        );
    }
    public likeComment(comment: Comment, currentUser: User) {
        const innerPost = comment;

        const reaction: NewReaction = {
            entityId: innerPost.id,
            isLike: true,
            isDislike: false,
            userId: currentUser.id
        };

        // update current array instantly
        let hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);
        let disliked =innerPost.reactions.some((x) => x.user.id === currentUser.id && x.isDislike == true);
        if(disliked){
            innerPost.reactions = innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
            .concat({ isLike: true, isDislike:false, user: currentUser });
        } else {
            innerPost.reactions = hasReaction
                ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                : innerPost.reactions.concat({ isLike: true, isDislike:false, user: currentUser });
        }
        hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);

        return this.commentService.likeComment(reaction).pipe(
            map(() => innerPost),
            catchError(() => {
                // revert current array changes in case of any error
                if(disliked){
                    innerPost.reactions = innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                    .concat({ isLike: true, isDislike:false, user: currentUser });
                } else {
                    innerPost.reactions = hasReaction
                        ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                        : innerPost.reactions.concat({ isLike: true, isDislike:false, user: currentUser });
                }
                return of(innerPost);
            })
        );
    }
    public dislikeComment(comment: Comment, currentUser: User) {
        const innerPost = comment;

        const reaction: NewReaction = {
            entityId: innerPost.id,
            isLike: false,
            isDislike: true,
            userId: currentUser.id
        };

        // update current array instantly
        let hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);
        let liked =innerPost.reactions.some((x) => x.user.id === currentUser.id && x.isLike == true);
        if(liked){
            innerPost.reactions = innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
            .concat({ isDislike: true, isLike:false, user: currentUser });
        } else {
            innerPost.reactions = hasReaction
                ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                : innerPost.reactions.concat({ isDislike: true, isLike:false, user: currentUser });
        }
        hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);

        return this.commentService.dislikeComment(reaction).pipe(
            map(() => innerPost),
            catchError(() => {
                // revert current array changes in case of any error
                if(liked){
                    innerPost.reactions = innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                    .concat({ isDislike: true, isLike:false, user: currentUser });
                } else {
                    innerPost.reactions = hasReaction
                        ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                        : innerPost.reactions.concat({ isDislike: true, isLike:false, user: currentUser });
                }
                return of(innerPost);
            })
        );
    }
    public dislikePost(post: Post, currentUser: User) {
        const innerPost = post;

        const reaction: NewReaction = {
            entityId: innerPost.id,
            isLike: false,
            isDislike: true,
            userId: currentUser.id
        };

        // update current array instantly
        let hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);
        let liked =innerPost.reactions.some((x) => x.user.id === currentUser.id && x.isLike == true);
        if(liked){
            innerPost.reactions = innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
            .concat({ isDislike: true, isLike:false, user: currentUser });
        } else {
            innerPost.reactions = hasReaction
                ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                : innerPost.reactions.concat({ isDislike: true, isLike:false, user: currentUser });
        }
        hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);

        return this.postService.dislikePost(reaction).pipe(
            map(() => innerPost),
            catchError(() => {
                // revert current array changes in case of any error
                if(liked){
                    innerPost.reactions = innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                    .concat({ isDislike: true, isLike:false, user: currentUser });
                } else {
                    innerPost.reactions = hasReaction
                        ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                        : innerPost.reactions.concat({ isDislike: true, isLike:false, user: currentUser });
                }
                return of(innerPost);
            })
        );
    }
}
