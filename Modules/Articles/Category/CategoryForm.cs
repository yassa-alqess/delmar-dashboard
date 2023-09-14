using Serenity.ComponentModel;

namespace Dashboard.Articles.Forms;

[FormScript("Articles.Category")]
[BasedOnRow(typeof(CategoryRow), CheckNames = true)]
public class CategoryForm
{
    [Width(100)]
    public string Title { get; set; }
}