<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/TemplateAdmin/admin.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="pagemanagement.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.Admin.TemplateAdmin.pagemanagement" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="form-group">
    <label>Page Name:</label>
      <asp:TextBox ID="txtPageName" runat="server" CssClass="form-control" placeholder="Page Name"></asp:TextBox>
  </div>
  <div class="form-group">
    <label>Page Content:</label>
      <ckeditor:ckeditorcontrol ID="ck_contenet" runat="server"></ckeditor:ckeditorcontrol>
      <%--<asp:TextBox ID="txtPageContent" TextMode="MultiLine" runat="server" CssClass="form-control" placeholder="Page Content"></asp:TextBox>--%>
  </div>
    <div class="form-group">
    <label>Title:</label>
      <asp:TextBox ID="txtTitle" TextMode="MultiLine" runat="server" CssClass="form-control" placeholder="Title"></asp:TextBox>
  </div>
    <div class="form-group">
    <label>Description:</label>
      <asp:TextBox ID="txtDescription" TextMode="MultiLine" runat="server" CssClass="form-control" placeholder="Description"></asp:TextBox>
  </div>
        <div class="form-group">
    <label>Keywords:</label>
      <asp:TextBox ID="txtKeywords" TextMode="MultiLine" runat="server" CssClass="form-control" placeholder="Keywords"></asp:TextBox>
  </div>
  <div class="checkbox">
    <label>
      <asp:CheckBox ID="chkIsActive"  runat="server" />  IsActive
    </label>
  </div>
    <%--<label>Page Çekme:</label>
    <div class="form-group">
        <asp:DropDownList ID="drpPages" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>--%>
   
    <asp:Button ID="btnSave" CssClass="btn btn-success" runat="server" Text="Save" OnClick="btnSave_Click"  />
    <asp:Button ID="btnUpdate" CssClass="btn btn-default" Text="Update" OnClick="btnUpdate_Click" runat="server"  />
  
</asp:Content>
