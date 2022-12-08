<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="TODO_Web.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" 
        href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" 
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" 
        crossorigin="anonymous"/>
    <title>Admin</title>
</head>
<body>
    <form id="frmAdmin" runat="server">
        <nav class="navbar navbar-dark bg-dark">
            <a href="#" class="navbar-brand">TODO APP</a>
                <ul class="navbar-nav">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Home / Admin</a>
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
                    <asp:label runat="server" Text="Task"/>
                    <asp:TextBox ID="tbTitle" runat="server"></asp:TextBox>
                    <br/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="plz enter a task" ControlToValidate="tbTitle" 
                        ValidationGroup="add" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br/><asp:label runat="server" Text="for User"/>
                    <asp:DropDownList ID="ddlUser" runat="server"></asp:DropDownList>
                </div>
                <div class="col-sm-3">
                    <asp:Button ID="btnAdd" runat="server" Text="Add Task" CssClass="btn btn-dark" OnClick="btnAdd_Click" ValidationGroup="add" />
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-dark" OnClick="btnLogout_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete Task" CssClass="btn btn-dark" OnClick="btnDelete_Click" />
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
