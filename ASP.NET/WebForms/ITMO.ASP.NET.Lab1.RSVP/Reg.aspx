<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="ITMO.ASP.NET.Lab1.RSVP.Reg"
    MasterPageFile="~/Site.master" UnobtrusiveValidationMode="None" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="contentPlaceHolder1" runat="server">
    <div>
        <div>
            <h1>Приглашаем на семинар</h1>
            <p></p>
        </div>
        <div>
            <asp:ValidationSummary ID="validationSummary" runat="server" ShowModelStateErrors="true" />
            <label>Ваше имя:</label>
            <asp:TextBox ID="name" runat="server">
            </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="name" 
                ErrorMessage="Заполните поле имени" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Ваш email:</label>
            <asp:TextBox ID="email" runat="server">
            </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ControlToValidate="email" 
                ErrorMessage="Заполните поле адреса почты" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" ControlToValidate="email"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ErrorMessage="E-mail is not in a valid format" Display="Dynamic"
                ForeColor="Red">Адрес введен неверно!!!</asp:RegularExpressionValidator>
        </div>
        <div>
            <label>Ваш телефон:</label>
            <asp:TextBox ID="phone" runat="server">
            </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                ControlToValidate="phone" 
                ErrorMessage="Заполните поле ввода телефона" 
                ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Вы будете делать доклад?</label>
            <asp:CheckBox ID="CheckBoxYN" runat="server" />
        </div>
        <div>
            <button type="submit">Отправить ответ на приглашение RSVP</button>
        </div>
    </div>
</asp:Content>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        
    </form>
</body>
</html>--%>
