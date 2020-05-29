<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso_Tema>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
    <div id="main-container">
    <table>
        <tr id="encabezado-tabla">
            <th></th>
           
            <th>
                IdCurso
            </th>
            <th>
                IdTema
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new {  id=item.IdCT }) %> |
                <%: Html.ActionLink("Detalles", "Details", new {  id=item.IdCT })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new {id=item.IdCT})%>
            </td>
            
            <td>
                <%: item.IdCurso %>
            </td>
            <td>
                <%: item.IdTema %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Agregar Curso Tema", "Create") %>
    </p>
    </div>

</body>
</html>

