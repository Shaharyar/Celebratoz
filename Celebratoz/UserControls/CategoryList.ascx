<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CategoryList.ascx.cs" Inherits="UserControls_CategoryList" %>


<asp:DataList ID="list" runat="server" Width="200px" style="margin-top: 10px" BorderStyle="Solid" BorderColor="#c4bebe" BorderWidth="1px"  > 
    <HeaderStyle CssClass="CategoryListHead" />  
    <HeaderTemplate>Shop by Category</HeaderTemplate>    
    <ItemTemplate>    
        <asp:HyperLink 
            ID="HyperLink1" 
            Runat="server" 
            NavigateUrl='<%# Link.ToCategory(Eval("Category_Id").ToString())%>' 
            Text='<%# HttpUtility.HtmlEncode(Eval("Name").ToString()) %>' 
            ToolTip='<%# HttpUtility.HtmlEncode(Eval("Description").ToString()) %>' 
            CssClass='<%# Eval("Category_Id").ToString() == Request.QueryString["Category_Id"] ? "CategorySelected" : "CategoryUnselected" %>'>    

        </asp:HyperLink>  
    </ItemTemplate> 
</asp:DataList>