using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Dashboard.Articles.CommentsRow>;
using MyRow = Dashboard.Articles.CommentsRow;

namespace Dashboard.Articles;

public interface ICommentsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CommentsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICommentsListHandler
{
    public CommentsListHandler(IRequestContext context)
            : base(context)
    {
    }
}