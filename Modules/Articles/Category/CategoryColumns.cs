using Serenity.ComponentModel;
using System.ComponentModel;

namespace Dashboard.Articles.Columns;

[ColumnsScript("Articles.Category")]
[BasedOnRow(typeof(CategoryRow), CheckNames = true)]
public class CategoryColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId")]
    public int CategoryId { get; set; }
    [EditLink]
    public string Title { get; set; }
}