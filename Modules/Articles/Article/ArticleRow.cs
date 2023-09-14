using Dashboard.Administration;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Dashboard.Articles;

[ConnectionKey("Default"), Module("Articles"), TableName("[serene].[Article]")]
[DisplayName("Article"), InstanceName("Article")]
[ReadPermission(PermissionKeys.Articles)]
[ModifyPermission(PermissionKeys.Articles)]
[InsertPermission(PermissionKeys.Articles)]
public sealed class ArticleRow : Row<ArticleRow.RowFields>, IIdRow, INameRow
{
    const string jCategory = nameof(jCategory);
    const string jAuther = nameof(jAuther);

    [DisplayName("Article Id"), Identity, IdProperty]
    public int? ArticleId
    {
        get => fields.ArticleId[this];
        set => fields.ArticleId[this] = value;
    }

    [DisplayName("Title"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Title
    {
        get => fields.Title[this];
        set => fields.Title[this] = value;
    }

    [DisplayName("Html Content"), NotNull]
    [HtmlContentEditor(Rows = 20)]
    public string HtmlContent
    {
        get => fields.HtmlContent[this];
        set => fields.HtmlContent[this] = value;
    }

    [DisplayName("Image"), Size(100)]
    [ImageUploadEditor(FilenameFormat = "Articles/PrimaryImage_{0}_{2}")]
    public string Image
    {
        get => fields.Image[this];
        set => fields.Image[this] = value;
    }

    [DisplayName("Is Active"), NotNull, DefaultValue(true)]
    public bool? IsActive
    {
        get => fields.IsActive[this];
        set => fields.IsActive[this] = value;
    }

    [DisplayName("Category"), NotNull, ForeignKey("[serene].[Category]", "CategoryId"), LeftJoin(jCategory), TextualField(nameof(CategoryTitle))]
    [LookupEditor(typeof(CategoryRow), InplaceAdd = true)]
    public int? CategoryId
    {
        get => fields.CategoryId[this];
        set => fields.CategoryId[this] = value;
    }

    [DisplayName("Auther"), ForeignKey("[serene].[Users]", "UserId"), LeftJoin(jAuther), TextualField(nameof(AutherUsername))]
    [LookupEditor(typeof(UserRow))]
    [ReadOnly(true)]
    public int? AutherId
    {
        get => fields.AutherId[this];
        set => fields.AutherId[this] = value;
    }

    [DisplayName("Created At"), QuickSearch(SearchType.Equals)]
    public DateTime? CreatedAt
    {
        get => fields.CreatedAt[this];
        set => fields.CreatedAt[this] = value;
    }

    [DisplayName("Updated At"), QuickSearch(SearchType.Equals)]
    public DateTime? UpdatedAt
    {
        get => fields.UpdatedAt[this];
        set => fields.UpdatedAt[this] = value;
    }

    [DisplayName("Category Title"), Expression($"{jCategory}.[Title]") ]
    public string CategoryTitle
    {
        get => fields.CategoryTitle[this];
        set => fields.CategoryTitle[this] = value;
    }

    [DisplayName("Auther Name"), Expression($"{jAuther}.[Username]"), QuickSearch]
    public string AutherUsername
    {
        get => fields.AutherUsername[this];
        set => fields.AutherUsername[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field ArticleId;
        public StringField Title;
        public StringField HtmlContent;
        public StringField Image;
        public BooleanField IsActive;
        public Int32Field CategoryId;
        public Int32Field AutherId;
        public DateTimeField CreatedAt;
        public DateTimeField UpdatedAt;

        public StringField CategoryTitle;
        public StringField AutherUsername;
    }
}