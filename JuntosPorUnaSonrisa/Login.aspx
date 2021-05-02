<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JuntosPorUnaSonrisa.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login Page</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="styles.css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="Estilos/Normal.css" />
</head>
<body>

    <div class="container">
        <div class="d-flex justify-content-center h-100">
            <div class="card">
                <div class="card-header">
                    <h3>Registrarse</h3>
                    <div class="d-flex justify-content-end social_icon">
                        <span><i class="fab fa-facebook-square"></i></span>
                        <span><i class="fab fa-google-plus-square"></i></span>
                        <span><i class="fab fa-twitter-square"></i></span>
                    </div>
                </div>
                <form runat="server">
                    <div class="card-body">
                        <div class="input-group form-group">
                            <div class="input-group-prepend">
                                <span class="input-group-text"><i class="fas fa-user"></i></span>
                            </div>
                            <asp:TextBox runat="server" ID="TxtUsuario" CssClass="form-control" />
                        </div>
                        <div class="input-group form-group">
                            <div class="input-group-prepend">
                                <span class="input-group-text"><i class="fas fa-key"></i></span>
                            </div>
                            <asp:TextBox runat="server" ID="TxtKey" TextMode="Password" CssClass="form-control" />
                        </div>
                        <div class="row align-items-center remember">
                            <input type="checkbox" />Recuérdame
                        </div>
                        <div class="form-group row">
                            <asp:Label runat="server" ID="LblError" EnableViewState="false" CssClass="col-sm text-danger alert-danger text-center"></asp:Label>
                        </div>
                        <div class="form-group float-right text-center" runat="server">
                            <asp:Button ID="BtnAceptar" CssClass="btn login_btn" Text="Aceptar" OnClick="BtnAceptar_Click" runat="server" />
                            &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" OnClick="BtnCancelar_Click" runat="server" />
                        </div>

                    </div>
                    <br />
                    <div class="card-footer">
                      
                        <div class="d-flex justify-content-center row alert-info">
                            <asp:Label Text="¿Necesitas una cuenta?"  runat="server" />
                        </div>
                         <div class="d-flex justify-content-center row alert-info">
                             <asp:Label Text="¿Olvidaste tu contraseña? "  runat="server" />
                        </div>
                         <div class="d-flex justify-content-center row alert-info">
                            
                            <asp:Label Text="Contacta con Administración"  runat="server" />
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>

</body>
</html>
