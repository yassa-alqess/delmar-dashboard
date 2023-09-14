import { StringEditor, HtmlContentEditor, ImageUploadEditor, LookupEditor, BooleanEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { CategoryDialog } from "@/Articles/Category/CategoryDialog";
import { CommentsGrid } from "@/Articles/Comments/CommentsGrid";
import { initFormType } from "@serenity-is/corelib/q";

export interface ArticleForm {
    Title: StringEditor;
    HtmlContent: HtmlContentEditor;
    Image: ImageUploadEditor;
    AutherId: LookupEditor;
    IsActive: BooleanEditor;
    CategoryId: LookupEditor;
    CreatedAt: DateEditor;
    UpdatedAt: DateEditor;
    CommentsGrid: CommentsGrid;
}

export class ArticleForm extends PrefixedContext {
    static formKey = 'Articles.Article';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ArticleForm.init)  {
            ArticleForm.init = true;

            var w0 = StringEditor;
            var w1 = HtmlContentEditor;
            var w2 = ImageUploadEditor;
            var w3 = LookupEditor;
            var w4 = BooleanEditor;
            var w5 = DateEditor;
            var w6 = CommentsGrid;

            initFormType(ArticleForm, [
                'Title', w0,
                'HtmlContent', w1,
                'Image', w2,
                'AutherId', w3,
                'IsActive', w4,
                'CategoryId', w3,
                'CreatedAt', w5,
                'UpdatedAt', w5,
                'CommentsGrid', w6
            ]);
        }
    }
}

[CategoryDialog]; // referenced types