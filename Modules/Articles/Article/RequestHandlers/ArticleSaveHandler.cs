using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Linq;
using MyRequest = Serenity.Services.SaveRequest<Dashboard.Articles.ArticleRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Dashboard.Articles.ArticleRow;

namespace Dashboard.Articles;

public interface IArticleSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ArticleSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IArticleSaveHandler
{
    public ArticleSaveHandler(IRequestContext context)
        : base(context)
    {  
    }
    protected override void BeforeSave()
    {
        base.BeforeSave();
        if (Row.AutherId == null)
            Row.AutherId = (Int32)User.GetIdentifier().TryParseID();
      
            Row.UpdatedAt = (DateTime.Now);
            Row.CreatedAt = (DateTime.Now);

    }

}