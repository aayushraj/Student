<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Student.aspx.cs" Inherits="Admin_Dashboard" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <br />

         <asp:Label ID="txtMessage" runat="server" CssClass=""></asp:Label>
    
        <div class ="form-group">
                <h3><label class="label label-default">First Name</label></h3>
                <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

         <div class ="form-group">
                <h3><label class="label label-default">Mid Name</label></h3>
                <asp:TextBox ID="txtMidname" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

         <div class ="form-group">
                <h3><label class="label label-default">Last Name</label></h3>
                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

         <div class ="form-group">
                <h3><label class="label label-default">Address</label></h3>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

         <div class ="form-group">
                <h3><label class="label label-default">Contact</label></h3>
                <asp:TextBox ID="txtContact" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

         <div class ="form-group">
                <h3><label class="label label-default">Email</label></h3>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    

    <asp:Button ID="btnAdd" runat="server" Text="Save" CssClass="btn btn-success btn-lg" OnClick="btnAdd_Click" />
    

</asp:Content>
