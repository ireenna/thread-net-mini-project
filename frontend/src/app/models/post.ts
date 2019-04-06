import { User } from './user';
import { Image } from './image';

export class Post {
    public user: User;
    public preview: Image;
    public body: string;
}
