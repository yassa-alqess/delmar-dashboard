using Serenity.Data;
using Serenity;
using Serenity.Services;
using System;
using MyRequest = Dashboard.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<Dashboard.Administration.UserRow>;
using MyRow = Dashboard.Administration.UserRow;

namespace Dashboard.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
       /* protected override void ApplyFilters(SqlQuery query)
        {
            base.ApplyFilters(query);
            if (User.Identity.Name != "admin")
            {
                var usr = (Int32)User.GetIdentifier().TryParseID();
                query.Where(MyRow.Fields.UserId == usr);
            }
        }
       */

    }
}