<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="AASK.AddProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Create Products</h1>
    <p class="lead">Fill in new product details.</p>
    <table>
        <tr>
            <td style="height: 24px">
                <asp:Label ID="ProductIDLabel" runat="server" Text="Product ID"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:TextBox ID="ProductIDTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="ProductNameLabel" runat="server" Text="Product Name"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:TextBox ID="ProductNameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="SupplierIDLabel" runat="server" Text="Supplier ID"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:TextBox ID="SupplierIDTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                <asp:Label ID="CategoryLabel" runat="server" Text="Category"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:DropDownList ID="CategoryDropDownList" runat="server" style="width: 130px; height: 24px"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="QuantityPerUnitLabel" runat="server" Text="Quantity Per Unit"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:TextBox ID="QuantityPerUnitTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="UnitPriceLabel" runat="server" Text="Unit Price"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:TextBox ID="UnitPriceTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="UnitsInStockLabel" runat="server" Text="Units In Stock"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:TextBox ID="UnitsInStockTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="UnitsOnOrderLabel" runat="server" Text="Units On Order"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:TextBox ID="UnitsOnOrderTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="ReorderLevelLabel" runat="server" Text="Reorder Level"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:TextBox ID="ReorderLevelTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="DiscontinuedLabel" runat="server" Text="Discontinued"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:DropDownList ID="DiscontinuedDropDownList" runat="server" style="width: 130px; height: 24px">
                    <asp:ListItem Text="Select" Value=""></asp:ListItem>
                    <asp:ListItem Text="Yes" Value="1"></asp:ListItem>
                    <asp:ListItem Text="No" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="OnlineLabel" runat="server" Text="Online"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:DropDownList ID="OnlineDropDownList" runat="server" style="width: 130px; height: 24px">
                    <asp:ListItem Text="Select" Value=""></asp:ListItem>
                    <asp:ListItem Text="Yes" Value="1"></asp:ListItem>
                    <asp:ListItem Text="No" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="SaleLabel" runat="server" Text="Sale"></asp:Label>
            </td>
            <td style="width: 130px; height: 24px">
                <asp:DropDownList ID="SaleDropDownList" runat="server" style="width: 130px; height: 24px">
                    <asp:ListItem Text="Select" Value=""></asp:ListItem>
                    <asp:ListItem Text="Yes" Value="1"></asp:ListItem>
                    <asp:ListItem Text="No" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="SubmitButton" runat="server" Text="Submit" Width="125px" OnClick="onSubmitButtonClick"/>
    <br />
    <br />
    <asp:Label ID="NotifyLabel" runat="server" Text="" Visible="false"></asp:Label>
    <br />
</asp:Content>
