<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductsList.ascx.cs" Inherits="UserControls_ProductsList" %>
<%@ Register src="Pager.ascx" tagname="Pager" tagprefix="uc1" %>


<asp:DataList ID="list" runat="server" RepeatColumns="3"   Visible="true">
    <HeaderStyle CssClass="ProductsListHead" />  
    <HeaderTemplate>Featured Products</HeaderTemplate>  
      <ItemTemplate>    
        <div class="Product">
         
          <a href="<%# Link.ToProduct(Eval("Product_Id").ToString()) %>">      
              <img width="200" height="200" border="0" src="<%# Link.ToProductImage(Eval("Thumbnail").ToString()) %>" 
                  alt='<%# HttpUtility.HtmlEncode(Eval("Thumbnail").ToString())%>' />    

          </a>
          <h3 class="ProductTitle">      
              <a href="<%# Link.ToProduct(Eval("Product_Id").ToString()) %>">        
                  <%# HttpUtility.HtmlEncode(Eval("Name").ToString()) %>      
              </a>    

          </h3>      
              
           <p style="color:#4A1C5E">     
                Price:      
               <%# Eval("Price", "{0:c}") %>   

           </p>  
        </div>
      </ItemTemplate> 
    
</asp:DataList>

<uc1:Pager ID="bottomPager" runat="server" Visible="False" />

