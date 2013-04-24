<%@ Page Title="BitChecker :: Contact" 
    Language="C#" 
    MasterPageFile="~/Primary.Master" 
    CodeBehind="Contact.aspx.cs" 
    Inherits="Bitchecker.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <h1>Send us a Message</h1>
        <p>Comments? Complaints? Success stories? Type in a message and hit the send button below.</p>
        <div><asp:TextBox runat="server" ID="txtMessage" Rows="10" Columns="50" TextMode="MultiLine" /></div>
        <div><asp:Button runat="server" OnClick="btnSend_Click" ID="bnSend" Text="Send Message" /></div>
    </form>
</asp:Content>
