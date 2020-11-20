<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page_3.aspx.cs" Inherits="TCC.page_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="age"></asp:Label>
            <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add To Viewstate" />
        <p>
            <asp:Button ID="btnview" runat="server" OnClick="btnview_Click" Text="view" />
        </p>
        <asp:Button ID="btndone" runat="server" OnClick="btndone_Click" Text="go to page2_query" />
        <p>
            <asp:Button ID="btnsession" runat="server" OnClick="btnsession_Click" Text="set session" />
        </p>
        <asp:Button ID="btncookie" runat="server" OnClick="btncookie_Click" Text="set cookie" />
    </form>
</body>
</html>
