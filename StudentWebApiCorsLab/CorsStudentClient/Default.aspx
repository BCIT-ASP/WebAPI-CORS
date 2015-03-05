<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CorsStudentClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Cors Request</h3>
    <button id="btnGetStudents">Get Students!</button>
    <pre id="preOutput"></pre>
    <script src="Scripts/jquery-2.1.3.js"></script>
    <script>
        $(function () {
            var getStudents = function () {
                var url = "http://w09a.matthewbanman.com/api/Students/";
                $.get(url).always(showResponse);
                return false;
            };

            var showResponse = function (object) {
                $("#preOutput").text(JSON.stringify(object, null, 4));
            };

            $("#btnGetStudents").click(getStudents);
        });
    </script>

</asp:Content>
