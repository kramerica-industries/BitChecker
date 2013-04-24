<%@ Page Title="BitChecker :: Free Scan" 
    Language="C#" 
    MasterPageFile="~/Primary.Master" 
    CodeBehind="Scan.aspx.cs" 
    Inherits="Bitchecker.Scan" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
 
    <h1>FREE BitScan&trade;</h1>
    <form runat="server" id="frmMain">
        <p>It's easy. Simply browse for a file and hit the Scan button below.</p>
        <div>
        <asp:FileUpload runat="server" ID="ctlFile" />
        <asp:Button runat="server" OnClick="btnScan_Click" ID="btnScan" Text="Scan File" />
        </div>
        <p>Disclaimer: although BitChecker's Patent Pending process is designed to detect all rogue bits, we cannot guarantee that a rogue bit will not be introduced once the file is open again. We are confident, however, that our services and processes will <em>never</em> produce a rogue bit.</p>
    </form>
    <div>
    <asp:Literal runat="server" ID="litScanResults" />
    </div>
</asp:Content>
