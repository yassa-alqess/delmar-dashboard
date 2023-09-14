using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Dashboard.Articles.CommentsRow>;
using MyRow = Dashboard.Articles.CommentsRow;

namespace Dashboard.Articles;

public interface ICommentsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CommentsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICommentsRetrieveHandler
{
    public CommentsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}