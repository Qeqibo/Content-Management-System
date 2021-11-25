<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="SifreDegis.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.Admin.SifreDegis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:label runat="server" text="Kullanıcı Adı:"></asp:label><br />
          <asp:textbox runat="server" ID="txtUsername"></asp:textbox><br />
         <asp:label runat="server" text="Eski Şifre"></asp:label><br />

  
         <asp:textbox runat="server" ID="txtPasswordOld"></asp:textbox> <br />
         <asp:label runat="server" text="Yeni Şifre"></asp:label><br />
         <asp:textbox runat="server" ID="txtPasswordNew"></asp:textbox> <br />

       <asp:button runat="server" text="Kaydet" ID="btnKaydet" OnClick="btnKaydet_Click" />
    
    </div>
    </form>
</body>
</html>
