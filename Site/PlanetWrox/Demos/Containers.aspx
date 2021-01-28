<%@ Page Title= "Containers" Language="vb" AutoEventWireup="false" CodeBehind="Containers.aspx.vb" Inherits="PlanetWrox.Containers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="Show Panel" />
            <asp:Panel ID="Panel1" runat="server">
                <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" Width="500px">
                    <WizardSteps>
                        <asp:WizardStep runat="server" title="About you">
                            <asp:Label ID="Label1" runat="server" Text="Typer Your Name"></asp:Label>
                            <asp:TextBox ID="YourName" runat="server"></asp:TextBox>
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" title="Favorite Language" StepType="Finish">
                            <asp:DropDownList ID="FavoriteLanguage" runat="server">
                                <asp:ListItem>C#</asp:ListItem>
                                <asp:ListItem>Visual Basic</asp:ListItem>
                                <asp:ListItem>CSS</asp:ListItem>
                            </asp:DropDownList>
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" StepType="Complete" Title="Ready">
                            <asp:Label ID="Result" runat="server" Text="Label"></asp:Label>
                        </asp:WizardStep>
                    </WizardSteps>
                </asp:Wizard>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
