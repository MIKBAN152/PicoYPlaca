<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="PicoYPlaca._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pico Y Placa - Predictor</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Ingrese Placa (ej. PCA0123):</p>
        <asp:TextBox ID="tbPlaca" Text="" runat="server" />
        <asp:Label ID="lblPlaca" runat="server" Text="" />
        <p>Ingrese Fecha (ej. dd/mm/aaaa):</p>
        <asp:TextBox ID="tbFecha" Text="" runat="server" />
        <asp:Label ID="lblFecha" runat="server" Text="" />
        <p>Ingrese Hora (ej. hh:mm):</p>
        <asp:TextBox ID="tbHora" Text="" runat="server" />
        <asp:Label ID="lblHora" runat="server" Text="" />
        <p>
            <asp:Button ID ="btnSend" Text="PYP ?" runat ="server" OnClick="fnCheck"/>
            <asp:Label ID="lblResult" runat="server" Text="" />
        </p>
    </div>
    </form>
</body>
</html>
