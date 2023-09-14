using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Dashboard.Articles.CategoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Dashboard.Articles.CategoryRow;

namespace Dashboard.Articles;

public interface ICategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategorySaveHandler
{
    public CategorySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}