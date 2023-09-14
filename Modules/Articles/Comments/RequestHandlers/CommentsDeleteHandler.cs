using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Dashboard.Articles.CommentsRow;

namespace Dashboard.Articles;

public interface ICommentsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class CommentsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICommentsDeleteHandler
{
    public CommentsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}