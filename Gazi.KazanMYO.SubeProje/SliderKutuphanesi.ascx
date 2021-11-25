<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SliderKutuphanesi.ascx.cs" Inherits="Gazi.KazanMYO.SubeProje.WebUserControl1" %>
<div>

   <asp:Repeater ID="rptResimler" runat="server">
            <HeaderTemplate> <ul class="bxslider"></HeaderTemplate>
            <ItemTemplate> <li><img src='~/Admin/TemplateAdmin/AnaTema/Resimler/<%#Eval("ResimYolu")%>' /></li></ItemTemplate>
            <FooterTemplate></ul></FooterTemplate>
        </asp:Repeater>
</div>