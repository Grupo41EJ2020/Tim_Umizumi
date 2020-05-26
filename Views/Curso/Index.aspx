﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<List<MVCLaboratorio.Models.Curso>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
    <link href="../../Content/EstilosUmizumi.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
   
    <table>
        <tr>
        <th></th>
            <th>
                <%: Html.LabelFor(p => Model[0].IdCurso) %>
            </th>
            <th>
                <%: Html.LabelFor(p => Model[0].Descripcion) %>
            </th>
            <th>
                <%: Html.LabelFor(p=> Model[0].NombreEmpleado) %>
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%: item.IdCurso %>
            </td>
            <td>
                <%: item.Descripcion %>
            </td>

            <td>
                <%: item.NombreEmpleado %>
            </td>
        </tr>
    
    <% } %>

    </table>

</body>
</html>
