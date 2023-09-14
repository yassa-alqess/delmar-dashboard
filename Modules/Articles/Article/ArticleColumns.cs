using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using System.Security.Permissions;

namespace Dashboard.Articles.Columns;

[ColumnsScript("Articles.Article")]
[BasedOnRow(typeof(ArticleRow), CheckNames = true)]
public class ArticleColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId")]
    public int ArticleId { get; set; }

    [EditLink, Width(200)]
    public string Title { get; set; }

    [Hidden]
    public string HtmlContent { get; set; }

    [Hidden]
    public string Image { get; set; }

    [Width(100)]
    public bool IsActive { get; set; }

    [QuickFilter, Width(200)]

    public string CategoryTitle { get; set; }

    [QuickFilter, Width(200)]
    [Hidden]
    public string AutherUsername { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}