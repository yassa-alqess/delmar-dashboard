using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Dashboard.Articles;

[ConnectionKey("Default"), Module("Articles"), TableName("[serene].[Comments]")]
[DisplayName("Comments"), InstanceName("Comments")]
[ReadPermission(PermissionKeys.Comments)]
//[ModifyPermission(PermissionKeys.Comments)]
//[InsertPermission(PermissionKeys.Comments)]
public sealed class CommentsRow : Row<CommentsRow.RowFields>, IIdRow, INameRow
{
    const string jArticle = nameof(jArticle);

    [DisplayName("Comment Id"), Identity, IdProperty]
    public int? CommentId
    {
        get => fields.CommentId[this];
        set => fields.CommentId[this] = value;
    }

    [DisplayName("Content"), NotNull, QuickSearch, NameProperty, Width(200)]
    public string Content
    {
        get => fields.Content[this];
        set => fields.Content[this] = value;
    }

    [DisplayName("Contact Id"), Size(200), NotNull]
    public string ContactId
    {
        get => fields.ContactId[this];
        set => fields.ContactId[this] = value;
    }

    [DisplayName("Username"), Size(200), NotNull]
    public string ContactName
    {
        get => fields.ContactName[this];
        set => fields.ContactName[this] = value;
    }

    [DisplayName("Article"), NotNull, ForeignKey("[serene].[Article]", "ArticleId"), LeftJoin(jArticle), TextualField(nameof(ArticleTitle))]
    public int? ArticleId
    {
        get => fields.ArticleId[this];
        set => fields.ArticleId[this] = value;
    }

    [DisplayName("Created At")]
    public DateTime? CreatedAt
    {
        get => fields.CreatedAt[this];
        set => fields.CreatedAt[this] = value;
    }

    [DisplayName("Article Title"), Expression($"{jArticle}.[Title]")]
    public string ArticleTitle
    {
        get => fields.ArticleTitle[this];
        set => fields.ArticleTitle[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field CommentId;
        public StringField Content;
        public StringField ContactId;
        public StringField ContactName;
        public Int32Field ArticleId;
        public DateTimeField CreatedAt;

        public StringField ArticleTitle;
    }
}