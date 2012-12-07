<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebRole1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Windows Azure GAC Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" Width="200" ID="assemblyName" />
        <asp:Button runat="server" OnClick="OnViewAssemblyButtonClick" ID="viewAssemblyButton" Text="Look up Assembly"  />
        <asp:Button runat="server" OnClick="OnViewAllButtonClick" ID="viewAllButton" Text="View all Assemblies"/>
        <br />
        <asp:TextBox runat="server" ID="ressultsBox" Width="600" Height="800" TextMode="MultiLine"/>
    </div>
    </form>
</body>
</html>
