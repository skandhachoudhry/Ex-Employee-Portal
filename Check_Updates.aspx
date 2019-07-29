<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Check_Updates.aspx.cs" Inherits="GAIL.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            width: 204px;
            text-align: center;
        }
        .style3
        {
            width: 311px;
        }
        .style4
        {
            width: 204px;
        }
        .style5
        {
            width: 204px;
            height: 232px;
        }
        .style6
        {
            width: 311px;
            height: 232px;
        }
        .style7
        {
            height: 232px;
        }
        .style8
        {
            width: 204px;
            text-align: center;
            height: 33px;
        }
        .style9
        {
            width: 311px;
            height: 33px;
        }
        .style10
        {
            height: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    c<table style="width:100%;">
        <tr>
            <td class="style2">
                Username</td>
            <td class="style3">
                <asp:TextBox ID="TextBox1" runat="server" Width="228px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Password</td>
            <td class="style3">
                <asp:TextBox ID="TextBox2" runat="server" Width="158px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="Button3" runat="server" Text="Show_Queries" Width="156px" OnClick= "Button3_Click" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Text="Updates" Width="130px" OnClick= "Button4_Click" />
            </td>
        </tr>
        <tr>
            <td class="style8">
                </td>
            <td class="style9">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;</td>
            <td class="style10">
                <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style5">
                </td>
            <td class="style6">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  Height="243px" Width="277px">

                <Columns>
                <asp:BoundField DataField="Query_ID" HeaderText="Query_ID" />
                <asp:BoundField DataField="Description" HeaderText="Query" />
                <asp:TemplateField>
                 <ItemTemplate>
                   <asp:LinkButton ID="linkSelect" Text="Reminder" runat="server"/></asp:LinkButton>
                 </ItemTemplate>
                </asp:TemplateField>
                 </Columns>
                </asp:GridView>
            </td>
            <td class="style7">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false">
                <Columns>
                <asp:BoundField DataField="Query_ID" HeaderText="Query_ID" />
                <asp:BoundField DataField="Solution" HeaderText="Solution" />

                </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
