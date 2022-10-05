<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="ITMO.ASP.NET.Lab1.RSVP.Summary" MasterPageFile="~/Site.master"%>

<asp:Content ID="MainContent" ContentPlaceHolderID="contentPlaceHolder1" runat="server">
<div>
    <h2>Приглашения</h2>
    <h3>Выступающие с докладом: </h3>
    <table>
        <thead>
            <tr>
                <th>Имя</th>
                <th>Email</th>
                <th>Телефон</th>
            </tr>
        </thead>
        <tbody> <!-- Insert C# code for LINQ query -->
            <% var yesData = ITMO.ASP.NET.Lab1.RSVP.ResponseRepository.GetRepository().GetAllResponses()
            .Where(r => r.WillAttend.Value);
            foreach (var rsvp in yesData)
                { 
                    string htmlString = String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td>", 
                        rsvp.Name, rsvp.Email, rsvp.Phone, rsvp.Rdata);
                    Response.Write(htmlString); 
                }
            %>
        </tbody>
    </table>
    <h3>Участники без доклада: </h3>
    <table>
        <thead>
            <tr>
                <th>Имя</th>
                <th>Email</th>
                <th>Телефон</th>
            </tr>
        </thead>
        <tbody> <%= GetNoShowHtml()%> </tbody> <!-- LING query is in Summary.aspx.cs file -->
    </table>
</div>
</asp:Content>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Участники семинара</title>
<link rel="stylesheet" href="Styles.css" />
</head>
    <body>
        <form id="form1" runat="server">
            
        </form>
    </body>
</html>--%>
