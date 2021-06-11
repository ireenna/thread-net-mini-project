import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { Post } from '../models/post/post';
import { NewReaction } from '../models/reactions/newReaction';
import { NewPost } from '../models/post/new-post';
import { EditPost } from '../models/post/edit-post';
import { Reaction } from '../models/reactions/reaction';

@Injectable({ providedIn: 'root' })
export class PostService {
    public routePrefix = '/api/posts';

    constructor(private httpService: HttpInternalService) {}

    public getPosts() {
        return this.httpService.getFullRequest<Post[]>(`${this.routePrefix}`);
    }

    public getLikedPosts() {
        return this.httpService.getFullRequest<Post[]>(`${this.routePrefix}/liked`);
    }

    // public getPostLikes(id: number) {
    //     return this.httpService.getFullRequest<Reaction[]>(`${this.routePrefix}/${id}/likes`);
    // }

    public createPost(post: NewPost) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}`, post);
    }

    public updatePost(post: EditPost, id:number) {
        return this.httpService.putFullRequest<Post>(`${this.routePrefix}/`+id, post);
    }

    public likePost(reaction: NewReaction) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}/like`, reaction);
    }

    public dislikePost(reaction: NewReaction) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}/dislike`, reaction);
    }
    
}
