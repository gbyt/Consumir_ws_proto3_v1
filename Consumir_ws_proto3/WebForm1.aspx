<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Consumir_ws_proto3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Consumir Web Service Prototipo 3</h1>
            <asp:Label ID="lnuma" Text="Valor 1: " runat="server" />
            <asp:TextBox ID="tnuma" runat="server" />
            <asp:Label ID="lnumb" Text="Valor 2: " runat="server" />
            <asp:TextBox ID="tnumb" runat="server" />
            <hr />
            <asp:Button ID="bSuma" Text="Suma" runat="server" OnClick="bSuma_Click" />
            <asp:Button ID="bResta" Text="Resta" runat="server" OnClick="bResta_Click" />
            <asp:Button ID="bMultiplica" Text="Multiplica" runat="server" OnClick="bMultiplica_Click" />
            <asp:Button ID="bDivide" Text="Dividir" runat="server" OnClick="bDivide_Click" />   
            <hr />
            <asp:Label ID="lResult" runat="server" />
        </div>
    </form>
</body>
</html>
