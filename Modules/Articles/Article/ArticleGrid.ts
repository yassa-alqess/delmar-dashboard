import { Decorators, EntityGrid, QuickSearchField } from '@serenity-is/corelib';
import { ArticleColumns, ArticleRow, ArticleService } from '@/ServerTypes/Articles';
import { ArticleDialog } from './ArticleDialog';
import { text, first, Authorization, indexOf } from '@serenity-is/corelib/q';
import { PermissionKeys, UserRow, UserService } from '../../Administration';

@Decorators.registerClass('Dashboard.Articles.ArticleGrid')
export class ArticleGrid extends EntityGrid<ArticleRow, any> {
    protected getColumnsKey() { return ArticleColumns.columnsKey; }
    protected getDialogType() { return ArticleDialog; }
    protected getRowDefinition() { return ArticleRow; }
    protected getService() { return ArticleService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
        //  filter by auther id and if it's admin then pass null to equality filter so it returns all articles.
        /*const ِAutherId = UserRow.Fields.UserId;
        const filterParam = AutherId == 1 ? null : AutherId;
*/        //this.setEquality(UserRow.Fields.UserId,fi);
    }
    protected getQuickSearchFields(): QuickSearchField[] {
        const fld = ArticleRow.Fields;
        const txt = (s) =>
            text(`Db.${ArticleRow.localTextPrefix}.${s}`).toLowerCase();
        return [
            { name: "", title: "all" },
            { name: fld.Title, title: txt(fld.Title)  },
            { name: fld.AutherUsername, title:txt(fld.AutherUsername)},
            { name: fld.CreatedAt, title: txt(fld.CreatedAt) },
            { name: fld.UpdatedAt, title: txt(fld.UpdatedAt) }
        ];
    }

    protected getColumns() {
        const cols = super.getColumns();
        const autherName = first(cols, x => x.field == ArticleRow.Fields.AutherUsername)
        if (Authorization.hasPermission(PermissionKeys.Security))
            autherName.visible = true;
        return cols;
    }    

    /*protected getGridCanLoad() {
        return this.AutherId != null || this._AutherId == 1;
    }

    private _AutherId: number;

    get AutherId() {
        return this._AutherId;
    }

    set AutherId(value: number) {
        if (this._AutherId != value) {
            this._AutherId = value;
            this.setEquality(UserRow.Fields.UserId, value);
            this.refresh();
        }
    }

    */


    protected getQuickFilters() {
        let filters = super.getQuickFilters();
        if (!Authorization.hasPermission(PermissionKeys.Security)) 
            filters.splice(indexOf(filters, x => x.field == ArticleRow.Fields.AutherUsername), 1);
        
        return filters;
    }
}