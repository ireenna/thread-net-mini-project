import { Post } from "../post/post";
import { User } from "../user";

export interface EmailSharePost {
    email: string;
    user: User;
    post: Post;
}