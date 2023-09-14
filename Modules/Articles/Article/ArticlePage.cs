using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Dashboard.Articles.Pages;

[PageAuthorize(typeof(ArticleRow))]
public class ArticlePage : Controller
{
    [Route("Articles/Article")]
    public ActionResult Index()
    {
        return this.GridPage("@/Articles/Article/ArticlePage",
            ArticleRow.Fields.PageTitle());
    }
}