<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridView.aspx.cs" Inherits="GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="375px">
                <Columns>
                    <asp:BoundField DataField="codigo" HeaderText="Código" />
                    <asp:TemplateField HeaderText="Embalagem">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("embalagem") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                Height="16px" Width="91px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" 

                                AutoPostBack="True">
                                <asp:ListItem>UN</asp:ListItem>
                                <asp:ListItem>CX</asp:ListItem>
                                <asp:ListItem>PT</asp:ListItem>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="qtd" HeaderText="Qtd" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
