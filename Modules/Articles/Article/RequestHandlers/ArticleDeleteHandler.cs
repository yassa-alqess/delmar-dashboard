using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Dashboard.Articles.ArticleRow;

namespace Dashboard.Articles;

public interface IArticleDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ArticleDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IArticleDeleteHandler
{
    public ArticleDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}