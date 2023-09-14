using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Dashboard.Articles.Columns;

[ColumnsScript("Articles.Comments")]
[BasedOnRow(typeof(CommentsRow), CheckNames = true)]
public class CommentsColumns
{
    [DisplayName("Db.Shared.RecordId")]
    //[EditLink,]
    public int CommentId { get; set; }
    //[EditLink]
    public string Content { get; set; }
   // public string ContactId { get; set; }
    public string ContactName { get; set; }

    [Hidden]
    public string ArticleTitle { get; set; }
    public DateTime CreatedAt { get; set; }
}