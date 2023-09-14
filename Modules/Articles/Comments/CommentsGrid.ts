import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ArticleRow, CommentsColumns, CommentsRow, CommentsService, PermissionKeys } from '@/ServerTypes/Articles';
import { Authorization, notifyError } from '@serenity-is/corelib/q';
import { parseInteger } from "@serenity-is/corelib/q";
import { BulkServiceAction } from '@serenity-is/extensions';
//import { CommentsDialog } from './CommentsDialog';

@Decorators.registerEditor('Dashboard.Articles.CommentsGrid')
export class CommentsGrid extends EntityGrid<CommentsRow, any> {
    protected getColumnsKey() { return CommentsColumns.columnsKey; }
    //protected getDialogType() { return CommentsDialog; }
    protected getRowDefinition() { return CommentsRow; }
    protected getService() { return CommentsService.baseUrl; }
    protected getLocalTextPrefix() { return CommentsRow.localTextPrefix; }
    private rowSelection: GridRowSelectionMixin;

    constructor(container: JQuery) {
        super(container);
    }
    protected getButtons() {
        let buttons = super.getButtons();
        buttons.forEach(b => {
            b.visible = false;
        });

        //add delete button
        if (Authorization.hasPermission(PermissionKeys.Comments))
        {
        // I will be adding a bulk delete button here later.
            buttons.push({
                title: 'Delete Comments',
                icon: 'fa fa-trash',
                visible: true,
                cssClass: 'delete-button',
                 onClick: e => {
                     //   debugger;
                     let commentIds = this.rowSelection.getSelectedKeys();
                     
                     if (commentIds.length > 0) {
                         var action = new DeleteBulkAction();
                         action.done = () => this.rowSelection.resetCheckedAndRefresh();
                         action.execute(commentIds);
                     } else notifyError('Please Select Rows to submit');
                 }
            });
        }
        return buttons;
    }
    protected createToolbarExtensions() {
        super.createToolbarExtensions();
        if (Authorization.hasPermission(PermissionKeys.Comments))
            this.rowSelection = new GridRowSelectionMixin(this);
    }
    protected getColumns() {
        const columns = super.getColumns();
        if (Authorization.hasPermission(PermissionKeys.Comments))
            columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        return columns;
    }
    

    protected getInitialTitle() {
        return null;
    }

    protected usePager() {
        return true; //use pagination
    }

    protected getGridCanLoad() {
        return this.ArticleId != null;
    }

    private _ArticleId: number;

    get ArticleId() {
        return this._ArticleId;
    }

    set ArticleId(value: number) {
        if (this._ArticleId != value) {
            this._ArticleId = value;
            this.setEquality(ArticleRow.Fields.ArticleId, value);
            this.refresh();
        }
    }
}

@Decorators.registerClass('Dashboard.Articles.DeleteBulkAction')
export class DeleteBulkAction extends BulkServiceAction {

    /**
     * This controls how many service requests will be used in parallel.
     * Determine this number based on how many requests your server
     * might be able to handle, and amount of wait on external resources.
     */
    protected getParallelRequests() {
        return 10;
    }

    /**
     * These number of records IDs will be sent to your service in one
     * service call. If your service is designed to handle one record only,
     * set it to 1. But note that, if you have 5000 records, this will
     * result in 5000 service calls / requests.
     */
    protected getBatchSize() {
        return 5;
    }

    protected sccss() {
        alert('sccss');
        debugger;
    }
    protected executeForBatch(batch) {

        CommentsService.DeleteList(
            {
                CommentIds: batch.map(x => parseInteger(x))
            },
            response => {
                this.set_successCount(this.get_successCount() + batch.length)
            },
            {
                blockUI: false,
                onError: response => this.set_errorCount(this.get_errorCount() + batch.length),
                onCleanup: () => this.serviceCallCleanup(),
            });

    }
}
