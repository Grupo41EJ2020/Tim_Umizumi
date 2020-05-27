<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso>" %>
<% List<SelectListItem> listaEmpleados = (List<SelectListItem>)ViewData["lista"];%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Edit</title>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Datos del Curso</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdCurso) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdCurso, new { @readonly = "readonly"})%>
                <%: Html.ValidationMessageFor(model => model.IdCurso) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Descripcion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Descripcion) %>
                <%: Html.ValidationMessageFor(model => model.Descripcion) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdEmpleado) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("idempleado", listaEmpleados)%>
                <%: Html.ValidationMessageFor(model => model.IdEmpleado) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar", "Index") %>
    </div>

</body>
</html>

