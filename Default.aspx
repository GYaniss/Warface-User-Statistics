<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" EnableEventValidation="false" %><!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Warface статистика игрока</title>
<style type="text/css">
.StyleTable table {border-width: 1px;border-style: solid;border-color: silver;border-collapse: collapse;}
.StyleTable th,.StyleTable td {border-width: 1px;border-style: solid;border-color: silver;}
.StyleTable thead tr td {text-align: center;font-family: Segoe UI;font-size: 20px;background-color: #f6f6f6;font-weight: bold;}
.StyleTable tbody tr td {margin:10px;padding:5px;font-family: Segoe UI;font-size: 18px;font-weight: bold;}
</style></head>
<body><form id="form1" runat="server">
       <center>
           <asp:Label ID="t0" runat="server" Font-Names="Sylfaen" Font-Size="22pt" Text="WARFACE"></asp:Label><br />
           <asp:Label ID="t1" runat="server" Text="статистика игрока" Font-Names="Sylfaen" Font-Overline="False" Font-Size="18pt"></asp:Label>
        <table>
            <tr>
                <td rowspan="2" style="vertical-align: bottom"></td>
                <td rowspan="2" style="vertical-align: bottom">
                    <asp:DropDownList ID="D1" runat="server" Font-Names="Calibri" Font-Size="20pt">
                        <asp:ListItem Value="0">Альфа</asp:ListItem>
                        <asp:ListItem Value="1">Браво</asp:ListItem>
                        <asp:ListItem Value="2">Чарли</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="text-align: center">
                 <asp:Label ID="t2" runat="server" Font-Names="Segoe UI" Font-Size="10pt" ForeColor="Gray" Text="(укажите имя персонажа на сервере)"></asp:Label>
                </td>
                <td style="text-align: center">
                    &nbsp;</td>
                <td style="text-align: center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                  <asp:TextBox ID="TB1" runat="server" Font-Names="Calibri" Font-Size="20pt" MaxLength="16" Width="300px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;&nbsp;</td>
                <td>
                    <asp:Button ID="B1" runat="server" Text="Ок" Width="68px" Height="30px" />
                </td>
            </tr>
        </table>
        <hr style="width: 681px" />
        <asp:Label ID="ErrTxt" runat="server" Font-Names="Arial" Font-Size="14pt" ForeColor="Red" Visible="false"></asp:Label>
        <asp:Literal ID="Gen" runat="server" EnableViewState="false"></asp:Literal></center> 
</form>
</body>
</html>
