<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso_Tema_Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
    <link href="../../Content/EstilosUmizumi.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="main-container">
    <table>
        <tr id = "Encabezado-Tabla">
            <th></th>
            <th>IdCTV</th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.IdCTV }) %> |
                <%: Html.ActionLink("Detalles", "Details", new { id=item.IdCTV })%> |
                <%: Html.ActionLink("ELIMINAR", "Delete", new { id=item.IdCTV })%>
            </td>

            <td>
            <%: item.IdCTV%>
            </td>

        </tr>
    
    <% } %>

    </table>
    <p>
        <%: Html.ActionLink("Agregar CTV", "Create") %>
    </p>
    </div>
</body>
</html>

