<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="KB_handson11_2.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fname" ErrorMessage="firstname required">*</asp:RequiredFieldValidator>
&nbsp;:
            <asp:TextBox ID="fname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="age" ErrorMessage="age required">*</asp:RequiredFieldValidator>
            :<asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="age" ErrorMessage="age must be greater than 16" Type="Integer" ValueToCompare="16" Operator="GreaterThanEqual">*</asp:CompareValidator>
&nbsp;<asp:TextBox ID="age" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="LoginName"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="loginname" ErrorMessage="login name required">*</asp:RequiredFieldValidator>
&nbsp;:
            <asp:TextBox ID="loginname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="password" ErrorMessage="password required">*</asp:RequiredFieldValidator>
            :
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="cpassword" ErrorMessage="confirm password is mandatory">*</asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator3" runat="server" ControlToCompare="password" ControlToValidate="cpassword" ErrorMessage="passwords doesnt match">*</asp:CompareValidator>
            :
            <asp:TextBox ID="cpassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Experience"></asp:Label>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="exp" ErrorMessage="experience cant be null">*</asp:RequiredFieldValidator>
            :<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="exp" ErrorMessage="experience must be between 5 and 10" MaximumValue="10" MinimumValue="5" Type="Integer">*</asp:RangeValidator>
&nbsp;<asp:TextBox ID="exp" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Salary Expected"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="sal" ErrorMessage="salary needed">*</asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="sal" ErrorMessage="salary must be less than 4lakh" Operator="LessThan" Type="Integer" ValueToCompare="400000">*</asp:CompareValidator>
            :
            <asp:TextBox ID="sal" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Button ID="button1" runat="server" OnClick="button1_Click" Text="Add New User" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="button2" runat="server" Text="Cancel" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>
    </form>
</body>
</html>
