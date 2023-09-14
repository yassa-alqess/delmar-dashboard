import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ArticleRow {
    ArticleId?: number;
    Title?: string;
    HtmlContent?: string;
    Image?: string;
    IsActive?: boolean;
    CategoryId?: number;
    AutherId?: number;
    CreatedAt?: string;
    UpdatedAt?: string;
    CategoryTitle?: string;
    AutherUsername?: string;
}

export abstract class ArticleRow {
    static readonly idProperty = 'ArticleId';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Articles.Article';
    static readonly deletePermission = 'Articles:Articles';
    static readonly insertPermission = 'Articles:Articles';
    static readonly readPermission = 'Articles:Articles';
    static readonly updatePermission = 'Articles:Articles';

    static readonly Fields = fieldsProxy<ArticleRow>();
}