import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CommentsRow {
    CommentId?: number;
    Content?: string;
    ContactId?: string;
    ContactName?: string;
    ArticleId?: number;
    CreatedAt?: string;
    ArticleTitle?: string;
}

export abstract class CommentsRow {
    static readonly idProperty = 'CommentId';
    static readonly nameProperty = 'Content';
    static readonly localTextPrefix = 'Articles.Comments';
    static readonly deletePermission = 'Articles:Comments';
    static readonly insertPermission = 'Articles:Comments';
    static readonly readPermission = 'Articles:Comments';
    static readonly updatePermission = 'Articles:Comments';

    static readonly Fields = fieldsProxy<CommentsRow>();
}