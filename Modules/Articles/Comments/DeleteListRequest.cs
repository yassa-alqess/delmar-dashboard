using Serenity.Services;
using System.Collections.Generic;

namespace Dashboard.Articles.Comments
{
    public class DeleteListRequest : ServiceRequest
    {
        public List<string> CommentIds { get; set; }
    }
}
