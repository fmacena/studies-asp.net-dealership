<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfCarro.aspx.cs" Inherits="waConcessionaria.wfCarro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Concessionaria</title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            height: 25px;
        }
        .auto-style2 {
            width: 50%;
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">MENU</td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlMenu" runat="server">
                            <asp:ListItem Value = "1">Listar marcas</asp:ListItem>
                            <asp:ListItem Value = "2">Listar carros de uma marca ordenadamente</asp:ListItem>
                            <asp:ListItem Value = "3">Cadastrar marca</asp:ListItem>
                            <asp:ListItem Value = "4">Cadastrar carro</asp:ListItem>
                            <asp:ListItem Value = "5">Cadastrar acessório</asp:ListItem>
                            <asp:ListItem Value = "6">Mostrar detalhes de um carro</asp:ListItem>
                            <asp:ListItem Value = "7">Sair</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button1" runat="server" Text="Go" Width="90px" OnClick="Button1_Click" />
                    </td>
                    <td class="auto-style2"> 
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        
                        <asp:PlaceHolder ID="phListagem" runat="server"></asp:PlaceHolder>
                        
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lbListagemDeMarcas" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
