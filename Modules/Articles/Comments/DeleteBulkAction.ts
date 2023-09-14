/*import { parseInteger } from "@serenity-is/corelib/q";
import { Decorators } from "@serenity-is/corelib";
import { BulkServiceAction } from '@serenity-is/extensions';
import { CommentsService } from "../../ServerTypes/Articles";

namespace Dashboard.Articles {

    @Decorators.registerClass('Dashboard.Comments.DeleteBulkAction')
    export class DeleteBulkAction extends BulkServiceAction {

        *//**
         * This controls how many service requests will be used in parallel.
         * Determine this number based on how many requests your server
         * might be able to handle, and amount of wait on external resources.
         *//*
        protected getParallelRequests() {
            return 10;
        }

        *//**
         * These number of records IDs will be sent to your service in one
         * service call. If your service is designed to handle one record only,
         * set it to 1. But note that, if you have 5000 records, this will
         * result in 5000 service calls / requests.
         *//*
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
}*/