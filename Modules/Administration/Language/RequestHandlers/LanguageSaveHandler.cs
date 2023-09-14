using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Dashboard.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Dashboard.Administration.LanguageRow;


namespace Dashboard.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}