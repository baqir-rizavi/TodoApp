<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TODO_Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" 
        href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" 
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" 
        crossorigin="anonymous"/>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrapcss"/>
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js">
    </script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js">
    </script>
    <link rel="stylesheet" href="Login.css"/>
    <title>Login</title>
</head>
<body>
    <form id="frmLogin" runat="server">
        <div>
            <div class="sidenav">
         <div class="login-main-text">
            <h2>TODO APP</h2>
            <p>Login or register from here to access.</p>
         </div>
      </div>
            <div class="main">
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
               <%--<form>--%>
                    <div class="form-group">
                        <label>User Name</label>
                        <asp:DropDownList ID="ddlUsername" runat="server" 
                            CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Password</label>
                        <asp:TextBox ID="tbPassword" 
                            runat="server"
                            type="text" 
                            CssClass="form-control" 
                            placeholder="Password">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator 
                            ID="pass" 
                            runat="server" 
                            ControlToValidate="tbPassword" 
                            ErrorMessage="Please enter a password"   
                            ForeColor="Red" 
                            ValidationGroup="login">
                        </asp:RequiredFieldValidator>  
                        <asp:label ID="lbFailedLogin" 
                            runat="server"
                            Visible="False" 
                            Text="Incorrect Username or Password"
                            ForeColor="Red">
                        </asp:label>
                    </div>
                    <asp:button runat="server" Text="Login" type="submit" CssClass="btn btn-black" ID="btnLogin" OnClick="btnLogin_Click" ValidationGroup="login"></asp:button>
                    <asp:button runat="server" Text="Register" CssClass="btn btn-secondary" ID="btnRegister" OnClick="btnRegister_Click"></asp:button>
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