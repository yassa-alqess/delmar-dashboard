import { ServiceRequest } from "@serenity-is/corelib/q";

export interface DeleteListRequest extends ServiceRequest {
    CommentIds?: string[];
}