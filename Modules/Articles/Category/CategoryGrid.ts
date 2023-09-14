import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CategoryColumns, CategoryRow, CategoryService } from '@/ServerTypes/Articles';
import { CategoryDialog } from './CategoryDialog';

@Decorators.registerClass('Dashboard.Articles.CategoryGrid')
export class CategoryGrid extends EntityGrid<CategoryRow, any> {
    protected getColumnsKey() { return CategoryColumns.columnsKey; }
    protected getDialogType() { return CategoryDialog; }
    protected getRowDefinition() { return CategoryRow; }
    protected getService() { return CategoryService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}