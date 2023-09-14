import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoryRow {
    CategoryId?: number;
    Title?: string;
}

export abstract class CategoryRow {
    static readonly idProperty = 'CategoryId';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Articles.Category';
    static readonly lookupKey = 'Articles.Category';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CategoryRow>('Articles.Category') }
    static async getLookupAsync() { return getLookupAsync<CategoryRow>('Articles.Category') }

    static readonly deletePermission = 'Articles:Categories';
    static readonly insertPermission = 'Articles:Categories';
    static readonly readPermission = 'Articles:Categories';
    static readonly updatePermission = 'Articles:Categories';

    static readonly Fields = fieldsProxy<CategoryRow>();
}