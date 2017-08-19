<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AASK._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>Products</h1>
        <p class="lead">List products based on search query and/or the checked boxes. </p>
        <p class="lead">Default: Lists all products in database.</p>
        <div style="height: 100px">
            <asp:TextBox ID="searchBox" runat="server" Height="30px" Width="780px" ></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="onSearchButtonClick" Height="34px" Width="131px" />
            <br /><br />
            
            <asp:CheckBox ID="onSale" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="On Sale"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:CheckBox ID="discontinued" runat="server" />
            <asp:Label ID="Label2" runat="server" Text="Discontinued"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:CheckBox ID="onlineOnly" runat="server" />
            <asp:Label ID="Label3" runat="server" Text="Online Only"></asp:Label>
            <br />
            
            <br />
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </div>

</asp:Content>
