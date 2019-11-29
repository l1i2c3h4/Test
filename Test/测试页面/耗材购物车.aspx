<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="耗材购物车.aspx.cs" Inherits="Test.测试页面.耗材购物车" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            耗材ID：
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;
            耗材名称：
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             &nbsp;
            耗材数量：
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Button ID="Button1" runat="server" Text="增加" OnClick="Button1_Click" />
            &nbsp;
            <asp:Button ID="Button2" runat="server" Text="删除" OnClick="Button2_Click" />
            <br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="HCID">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="HCID" HeaderText="耗材ID" />
                    <asp:BoundField DataField="name" HeaderText="耗材名称" />
                    <asp:BoundField DataField="num" HeaderText="耗材数量" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
