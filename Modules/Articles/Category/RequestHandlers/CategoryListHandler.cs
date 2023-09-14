using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Dashboard.Articles.CategoryRow>;
using MyRow = Dashboard.Articles.CategoryRow;

namespace Dashboard.Articles;

public interface ICategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryListHandler
{
    public CategoryListHandler(IRequestContext context)
            : base(context)
    {
    }
}