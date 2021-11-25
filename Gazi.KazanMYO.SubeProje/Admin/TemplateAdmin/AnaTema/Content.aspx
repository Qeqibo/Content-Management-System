<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/TemplateAdmin/AnaTema/master.Master" AutoEventWireup="true" CodeBehind="Content.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.WebForm2" %>
<%@ Register Src="~/SliderKutuphanesi.ascx" TagPrefix="uc1" TagName="SliderKutuphanesi" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Literal ID="litPagename" runat="server"></asp:Literal>
    <asp:Literal ID="litIcerik" runat="server"></asp:Literal>
    <%--<CKEditor:CKEditorControl ID="ckEditor" runat="server"></CKEditor:CKEditorControl>--%>
     <uc1:SliderKutuphanesi runat="server" ID="SliderKutuphanesi" />
   
</asp:Content>
