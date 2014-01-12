<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="ProductDetailsLeft">
   
    <p>    
         <asp:Image ID="productImage" runat="server" Height="350px" Width="350px" />  

    </p>
    </div>
    <div class="ProductDetailsRight">  
        <p>    
            <asp:Label CssClass="ProductName" ID="titleLabel" runat="server" Text="Label"></asp:Label>  

        </p>
        <p>    
            <asp:Label ID="descriptionLabel" runat="server" Text="Description"></asp:Label>  

        </p>  
        <p>    
            <b>Price:</b>    
            <asp:Label CssClass="ProductPrice" ID="priceLabel" runat="server" Text="Label"></asp:Label>  

        </p> 
    </div>

</asp:Content>

