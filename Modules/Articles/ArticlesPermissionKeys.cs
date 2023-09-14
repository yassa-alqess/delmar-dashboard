using Serenity.ComponentModel;
using System.ComponentModel;

namespace Dashboard.Articles
{
    [NestedPermissionKeys]
    [DisplayName("Articles")]
    public class PermissionKeys
    {
        [Description("User, Role Management and Permissions")]
        public const string Security = "Administration:Security";

        [Description("Read & Modify & Insert Articles")]
        public const string Articles = "Articles:Articles";

        [Description("Read & Modify & Insert Comments")]
        public const string Comments = "Articles:Comments";

        [Description("Read & Modify & Insert Categories")]
        public const string Categories = "Articles:Categories";
    }
}
