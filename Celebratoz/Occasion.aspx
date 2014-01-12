<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Occasion.aspx.cs" Inherits="Occasion" %>

<%@ Register src="UserControls/OccasionCatalog.ascx" tagname="OccasionCatalog" tagprefix="uc1" %>
<%@ Register src="UserControls/OccasionTitle.ascx" tagname="OccasionTitle" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <uc2:OccasionTitle ID="OccasionTitle1" runat="server" />
        <uc1:OccasionCatalog ID="OccasionCatalog1" runat="server" />
    </p>
</asp:Content>

