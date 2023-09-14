using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace Dashboard.Articles;

[ConnectionKey("Default"), Module("Articles"), TableName("[serene].[Category]")]
[DisplayName("Category"), InstanceName("Category")]
[ReadPermission(PermissionKeys.Categories)]
[ModifyPermission(PermissionKeys.Categories)]
[InsertPermission(PermissionKeys.Categories)]
[LookupScript("Articles.Category", Permission = PermissionKeys.Categories, Expiration = -1)]
public sealed class CategoryRow : Row<CategoryRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Category Id"), Identity, IdProperty]
    public int? CategoryId
    {
        get => fields.CategoryId[this];
        set => fields.CategoryId[this] = value;
    }

    [DisplayName("Title"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Title
    {
        get => fields.Title[this];
        set => fields.Title[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field CategoryId;
        public StringField Title;

    }
}