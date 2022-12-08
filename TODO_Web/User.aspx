<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="TODO_Web.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" 
        href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" 
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" 
        crossorigin="anonymous"/>
    <title>User</title>
</head>
<body>
    <form id="frmAdmin" runat="server">
        <nav class="navbar navbar-dark bg-dark">
            <a href="#" class="navbar-brand">TODO APP</a>
                <ul class="navbar-nav">
                    <li class="nav-item active">
                       <%-- <asp:HyperLink ID="HyperLink1" CssClass="nav-link" runat="server"></asp:HyperLink>--%>
                    </li>
                </ul>
            </nav>
        <br/>
        <div class="container">
            <div class="row">
                <div class="col-sm-4">
                    <asp:GridView ID="dgv" runat="server" AutoGenerateSelectButton="True">
                        <SelectedRowStyle BackColor="Silver" />
                    </asp:GridView>
                </div>
                <div class="col-sm-3">
                    <asp:Button ID="btnMark" runat="server" Text="Mark as Read" CssClass="btn btn-dark" OnClick="btnMark_Click"/>
                    <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-dark" Text="Logout" OnClick="btnLogout_Click" />
                </div>
            </div>
        </div>
    </form>

    <script 
        src="https://code.jquery.com/jquery-3.2.1.slim.min.js" 
        integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" 
        crossorigin="anonymous">
    </script>
    <script 
        src="https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js" 
        integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" 
        crossorigin="anonymous">
    </script>
    <script 
        src="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js" 
        integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" 
        crossorigin="anonymous">
    </script>
</body>
</html>
