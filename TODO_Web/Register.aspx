<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TODO_Web.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" 
        href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" 
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" 
        crossorigin="anonymous"/>
    <link 
        href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" 
        rel="stylesheet" 
        id="bootstrapcss"/>
    <script 
        src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js">
    </script>
    <script 
        src="//code.jquery.com/jquery-1.11.1.min.js">
    </script>
    <link 
        rel="stylesheet" 
        href="Login.css"/>
    <title>Register</title>
</head>
<body>
    <form id="frmRegister" runat="server">
        <div>
            <div class="sidenav">
         <div class="login-main-text">
            <h2>TODO APP</h2>
            <p><br/>Register as a user to have todo app at your side.</p>
         </div>
      </div>
            <div class="main">
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
               <%--<form>--%>
                    <div class="form-group">
                        <label>User Name</label>
                        <asp:TextBox ID="tbUsername" runat="server"
                            CssClass="form-control" 
                            placeholder="Usename">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator1" 
                            runat="server"
                            ErrorMessage="plz enter a username"
                            ForeColor="red"
                            ControlToValidate="tbUsername">
                        </asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Password</label>
                        <asp:TextBox ID="tbPassword" runat="server"
                            CssClass="form-control" 
                            placeholder="Password" 
                            TextMode="Password">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator2"
                            runat="server" 
                            ErrorMessage="plz enter a password" 
                            ForeColor="Red"
                            ControlToValidate="tbPassword">
                        </asp:RequiredFieldValidator>
                    </div>
                    <asp:Label
                        ID="lbUserExist"
                        runat="server" 
                        Text="user already exist" 
                        ForeColor="Red"
                        Visible="False"> 
                    </asp:Label>
                    <asp:button 
                        runat="server" 
                        type="submit" 
                        CssClass="btn btn-secondary" 
                        ID="btnRegister" Text="Register" OnClick="btnRegister_Click">
                    </asp:button>
                <%--</form>--%>
            </div>
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
