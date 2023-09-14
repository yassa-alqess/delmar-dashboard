using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Dashboard.Articles.CommentsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Dashboard.Articles.CommentsRow;

namespace Dashboard.Articles;

public interface ICommentsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CommentsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICommentsSaveHandler
{
    public CommentsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}