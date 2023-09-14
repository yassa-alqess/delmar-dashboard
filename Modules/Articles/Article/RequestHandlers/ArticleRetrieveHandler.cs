using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Dashboard.Articles.ArticleRow>;
using MyRow = Dashboard.Articles.ArticleRow;

namespace Dashboard.Articles;

public interface IArticleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ArticleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IArticleRetrieveHandler
{
    public ArticleRetrieveHandler(IRequestContext context)
            : base(context)
    {
        var user = context.User;
        if (user == null)
        {
            
        }
    }
}