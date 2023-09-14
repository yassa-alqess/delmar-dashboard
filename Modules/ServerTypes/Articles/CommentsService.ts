import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CommentsRow } from "./CommentsRow";
import { DeleteListRequest } from "./Comments.DeleteListRequest";

export namespace CommentsService {
    export const baseUrl = 'Articles/Comments';

    export declare function Create(request: SaveRequest<CommentsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CommentsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CommentsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CommentsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function DeleteList(request: DeleteListRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Articles/Comments/Create",
        Update: "Articles/Comments/Update",
        Delete: "Articles/Comments/Delete",
        Retrieve: "Articles/Comments/Retrieve",
        List: "Articles/Comments/List",
        DeleteList: "Articles/Comments/DeleteList"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'DeleteList'
    ].forEach(x => {
        (<any>CommentsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}