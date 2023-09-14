using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Linq;
using System.Security.Claims;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Dashboard.Articles.ArticleRow>;
using MyRow = Dashboard.Articles.ArticleRow;
namespace Dashboard.Articles;

public interface IArticleListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ArticleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IArticleListHandler
{
    IUserRetrieveService _userRetrieveService;
    public ArticleListHandler(IRequestContext context, IUserRetrieveService userRetrieveService)
            : base(context)
    {
        _userRetrieveService = userRetrieveService ??
                    throw new ArgumentNullException(nameof(userRetrieveService));
    }
    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);
        //if (Permissions.HasPermission(PermissionKeys.Security) == false)
        if (User.Identity.Name != "admin")
        {
            var autherId = (Int32)User.GetIdentifier().TryParseID();
            query.Where(MyRow.Fields.AutherId == autherId);
        }
    }
}
