import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ArticleForm, ArticleRow, ArticleService } from '@/ServerTypes/Articles';
import { first } from '@serenity-is/corelib/q';

@Decorators.registerClass('Dashboard.Articles.ArticleDialog')
@Decorators.panel()
export class ArticleDialog extends EntityDialog<ArticleRow, any> {
    protected getFormKey() { return ArticleForm.formKey; }
    protected getRowDefinition() { return ArticleRow; }
    protected getService() { return ArticleService.baseUrl; }

    protected form = new ArticleForm(this.idPrefix);

    protected afterLoadEntity() {
        super.afterLoadEntity();

        this.form.CommentsGrid.ArticleId = this.entity.ArticleId;
    }
    protected getToolbarButtons() {
        const buttons = super.getToolbarButtons();
        //console.log(buttons);

        const deleteButton = first(buttons, x => x.title == 'Delete');
        if(deleteButton)
            deleteButton.title = 'Delete Article';
          
        return buttons;

    }

}