<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Empleado>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Editar Empleado</title>
    <link href="../../Content/EstilosUmizumi.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Editar Empleado</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Direccion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Direccion) %>
                <%: Html.ValidationMessageFor(model => model.Direccion) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </div>

</body>
</html>

