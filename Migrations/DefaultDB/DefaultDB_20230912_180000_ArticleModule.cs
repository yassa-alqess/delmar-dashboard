using FluentMigrator;
using Serenity.Extensions;

namespace Dashboard.Migrations.DefaultDB
{
    [Migration(20230912_180000)]
    public class DefaultDB_20230912_180000_ArticleModule : AutoReversingMigration
    {
        public override void Up()
        {
            //Category Table
            Create.Table("Category").InSchema("serene")
               .WithColumn("CategoryId").AsInt32().Identity()
                   .PrimaryKey().NotNullable()
               .WithColumn("Title").AsString(200).NotNullable();


            //Article Table
            Create.Table("Article").InSchema("serene")
             .WithColumn("ArticleId").AsInt32().Identity()
                 .PrimaryKey().NotNullable()
             .WithColumn("Title").AsString(200).NotNullable()
             .WithColumn("HtmlContent").AsString(int.MaxValue).NotNullable()
             .WithColumn("Image").AsString(int.MaxValue).Nullable()
             .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(true)
             .WithColumn("CategoryId").AsInt32().NotNullable()
                  .ForeignKey("FK_Article_CategoryId", "serene", "Category", "CategoryId")
             .WithColumn("AutherId").AsInt32().NotNullable()
                  .ForeignKey("FK_Article_AutherId", "serene", "Users", "UserId")
             .WithColumn("CreatedAt").AsDateTime().NotNullable()
             .WithColumn("UpdatedAt").AsDateTime().NotNullable();


            //Comments Table
            Create.Table("Comments").InSchema("serene")
               .WithColumn("CommentId").AsInt32().Identity()
                   .PrimaryKey().NotNullable()
               .WithColumn("Content").AsString(int.MaxValue).NotNullable()
               .WithColumn("ContactId").AsString(200).NotNullable()
               .WithColumn("ContactName").AsString(200).NotNullable()
               .WithColumn("ArticleId").AsInt32().NotNullable()
                   .ForeignKey("FK_Comments_ArticleId", "serene", "Article", "ArticleId")
               .WithColumn("CreatedAt").AsDateTime().NotNullable();
        }
    }
}
