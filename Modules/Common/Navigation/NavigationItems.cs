using Serenity.Navigation;
using static Dashboard.Texts.Db;
using ArticlePages = Dashboard.Articles.Pages;
using AdministrationPages = Dashboard.Administration.Pages;

//Dashbord Navigation
[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

//Addministration Navigation
[assembly: NavigationMenu(2000, "Administration", icon: "fa-wrench")]
[assembly: NavigationLink(2100, "Administration/Languages", typeof(AdministrationPages.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(2200, "Administration/Translations", typeof(AdministrationPages.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(2300, "Administration/Roles", typeof(AdministrationPages.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(2400, "Administration/User Management", typeof(AdministrationPages.UserController), icon: "fa-users")]

//Articles Navigation
[assembly: NavigationMenu(3000, "Articles", icon: "fa fa-bars")]
[assembly: NavigationLink(3100, "Articles/Category", typeof(ArticlePages.CategoryPage), icon: "fa fa-folder-open-o")]
[assembly: NavigationLink(3200, "Articles/Article", typeof(ArticlePages.ArticlePage), icon: "fa fa-file-text-o")]
//[assembly: NavigationLink(3300, "Articles/Comments", typeof(ArticlePages.CommentsPage), Permission="Article:Article", icon: null)]

