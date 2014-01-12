<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Category" %>

<%@ Register src="UserControls/CategoriesCatalog.ascx" tagname="CategoriesCatalog" tagprefix="uc1" %>

<%@ Register src="UserControls/CategoryTitle.ascx" tagname="CategoryTitle" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    

    <uc2:CategoryTitle ID="CategoryTitle1" runat="server" />
    

    <uc1:CategoriesCatalog ID="CategoriesCatalog1" runat="server" />
    

</asp:Content>

