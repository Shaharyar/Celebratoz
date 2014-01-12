<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OccasionList.ascx.cs" Inherits="UserControls_OccasionList" %>
        
<asp:DataList ID="list" runat="server" Width="200px" style="margin-top: 10px" BorderStyle="Solid" BorderColor="#c4bebe" BorderWidth="1px"  > 
    <HeaderStyle CssClass="OccasionListHead" />  
    <HeaderTemplate>Shop by Occasion</HeaderTemplate>    
    <ItemTemplate>    
        <asp:HyperLink 
            ID="HyperLink1" 
            Runat="server" 
            NavigateUrl='<%# Link.ToOccasion(Eval("Occasion_Id").ToString())%>' 
            Text='<%# HttpUtility.HtmlEncode(Eval("Name").ToString()) %>' 
            ToolTip='<%# HttpUtility.HtmlEncode(Eval("Description").ToString()) %>' 
            CssClass='<%# Eval("Occasion_Id").ToString() == Request.QueryString["Occasion_Id"] ? "OccasionSelected" : "OccasionUnselected" %>'>    

        </asp:HyperLink>  
    </ItemTemplate> 
</asp:DataList>