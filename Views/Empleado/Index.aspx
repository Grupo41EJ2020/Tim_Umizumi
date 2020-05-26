<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Empleado>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
    <link href="../../Content/EstilosUmizumi.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="main-container">
        <table>
            <tr id="encabezado-tabla">
                <th></th>
                <th>
                    IdEmpleado
                </th>
                <th>
                    Nombre
                </th>
            </tr>

        <% foreach (var item in Model) { %>
    
            <tr>
                <td>
                    <%: Html.ActionLink("Editar", "Edit", new { id=item.IdEmpleado}) %> |
                    <%: Html.ActionLink("Detalles", "Details", new { id = item.IdEmpleado })%> |
                    <%: Html.ActionLink("Eliminar", "Delete", new { id = item.IdEmpleado })%>
                </td>
                <td>
                    <%: item.IdEmpleado %>
                </td>
                <td>
                    <%: item.Nombre %>
                </td>
            </tr>
    
        <% } %>

        </table>
    <p>
        <%: Html.ActionLink("Agregar un Empleado", "Create") %>
    </p>
    </div>

</body>
</html>

