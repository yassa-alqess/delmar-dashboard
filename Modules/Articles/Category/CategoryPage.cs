using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Dashboard.Articles.Pages;

[PageAuthorize(typeof(CategoryRow))]
public class CategoryPage : Controller
{
    [Route("Articles/Category")]
    public ActionResult Index()
    {
        return this.GridPage("@/Articles/Category/CategoryPage",
            CategoryRow.Fields.PageTitle());
    }
}