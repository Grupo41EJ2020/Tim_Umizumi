<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<List<MVCLaboratorio.Models.Curso>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
    <link href="../../Content/EstilosUmizumi.css" rel="stylesheet" type="text/css" />
</head>
<body>

    <table>
        <tr>
        <th><%: Html.ActionLink("Agregar", "Create") %></th>
            <th>
                <%: Html.LabelFor(p => Model[0].IdCurso) %>
            </th>
            <th>
                <%: Html.LabelFor(p => Model[0].Descripcion) %>
            </th>
            <th>
                <%: Html.LabelFor(p=> Model[0].IdEmpleado) %>
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id= item.IdCurso }) %> |
                <%: Html.ActionLink("Detalles", "Details", new { id = item.IdCurso })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id=item.IdCurso })%>
            </td>
            <td>
                <%: item.IdCurso %>
            </td>
            <td>
                <%: item.Descripcion %>
            </td>

            <td>
                <%: item.IdEmpleado %>
            </td>
        </tr>
    
    <% } %>

    </table>

</body>
</html>

