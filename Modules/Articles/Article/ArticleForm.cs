using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Dashboard.Articles.Forms;

[FormScript("Articles.Article")]
[BasedOnRow(typeof(ArticleRow), CheckNames = true)]
public class ArticleForm
{
    [Tab("Article")]
    public string Title { get; set; }
    public string HtmlContent { get; set; }
    public string Image { get; set; }

    [HideOnInsert]
    public int AutherId { get; set; }
    public bool IsActive { get; set; }
    public int CategoryId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    [Tab("Comments"), IgnoreName, CommentsGrid, LabelWidth("0")]
    public string CommentsGrid { get; set; } // column typd doesn't matter as it will be shown as Grid anyway
}