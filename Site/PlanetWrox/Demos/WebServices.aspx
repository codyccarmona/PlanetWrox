<%@ Page Title="Web Services Demo" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/Frontend.Master" CodeBehind="WebServices.aspx.vb" Inherits="PlanetWrox.WebServices" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
        <Services>
            <asp:ServiceReference Path="~/WebServices/NameService.asmx"/>
        </Services>
    </asp:ScriptManagerProxy>

    <input id="YourName" type="text"/>
    <input id="SayHello" type="button" value="Say Hello"/>
    <input id="SayHelloPageMethod" type="button" value="Say Hellow with a Page Method" />


    <script type="text/javascript">
        function HelloWorld() {
            var yourName = $get('YourName').value;
            PlanetWrox.NameService.HelloWorld(yourName, HelloWorldCallback);
        }

        function HelloWorldCallback(result) {
            alert(result);
        }

        function HelloWorldPageMethod() {
            var yourName = $get('YourName').value;
            PageMethods.HelloWorld(yourName, HelloWorldCallback);
        }

        $addHandler($get('SayHello'), 'click', HelloWorld);
        $addHandler($get('SayHelloPageMethod'), 'click', HelloWorldPageMethod)
    </script>
</asp:Content>
