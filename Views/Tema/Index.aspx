﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Tema>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
    <link href="../../Content/EstilosUmizumi.css" rel="stylesheet" type="text/css" /></head>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdTema
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.IdTema }) %> |
                <%: Html.ActionLink("Detalles", "Details", new { id=item.IdTema })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id=item.IdTema})%>
            </td>
            <td>
                <%: item.IdTema %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear Tema", "Create") %>
    </p>
    <a href="/Home/Index">Regresar</a>
</body>
</html>

