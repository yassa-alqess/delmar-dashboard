import{e as f}from"../../../_chunks/chunk-Y7WLXSHO.js";import{a as h,c as g,d as i,e as u}from"../../../_chunks/chunk-UX23F3MH.js";import{a as o,c,d as m,f as A,g as p}from"../../../_chunks/chunk-BX2ZHUFS.js";var x=c(p(),1);var d=c(A(),1);var a=c(A(),1);var y=c(p(),1);var s=class extends a.EntityDialog{constructor(){super(...arguments);this.form=new g(this.idPrefix)}getFormKey(){return g.formKey}getRowDefinition(){return i}getService(){return u.baseUrl}afterLoadEntity(){super.afterLoadEntity(),this.form.CommentsGrid.ArticleId=this.entity.ArticleId}getToolbarButtons(){let t=super.getToolbarButtons(),l=(0,y.first)(t,w=>w.title=="Delete");return l&&(l.title="Delete Article"),t}};o(s,"ArticleDialog"),s=m([a.Decorators.registerClass("Dashboard.Articles.ArticleDialog"),a.Decorators.panel()],s);var r=c(p(),1);var n=class extends d.EntityGrid{getColumnsKey(){return h.columnsKey}getDialogType(){return s}getRowDefinition(){return i}getService(){return u.baseUrl}constructor(e){super(e)}getQuickSearchFields(){let e=i.Fields,t=o(l=>(0,r.text)(`Db.${i.localTextPrefix}.${l}`).toLowerCase(),"txt");return[{name:"",title:"all"},{name:e.Title,title:t(e.Title)},{name:e.AutherUsername,title:t(e.AutherUsername)},{name:e.CreatedAt,title:t(e.CreatedAt)},{name:e.UpdatedAt,title:t(e.UpdatedAt)}]}getColumns(){let e=super.getColumns(),t=(0,r.first)(e,l=>l.field==i.Fields.AutherUsername);return r.Authorization.hasPermission(f.Security)&&(t.visible=!0),e}getQuickFilters(){let e=super.getQuickFilters();return r.Authorization.hasPermission(f.Security)||e.splice((0,r.indexOf)(e,t=>t.field==i.Fields.AutherUsername),1),e}};o(n,"ArticleGrid"),n=m([d.Decorators.registerClass("Dashboard.Articles.ArticleGrid")],n);function C(){(0,x.initFullHeightGridPage)(new n($("#GridDiv")).element)}o(C,"pageInit");export{C as default};
//# sourceMappingURL=ArticlePage.js.map
