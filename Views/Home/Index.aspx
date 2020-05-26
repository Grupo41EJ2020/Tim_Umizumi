<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Tim_Umizumi</title>
    <style type="text/css">
        * {
            margin:0px;
            padding:0px;
            font-family:Verdana, Geneva, Tahoma, sans-serif;
        }
        body{
            background-color:#2C2C2C;
        }

        header{
            margin:200px auto;
            width:1200px;
            height:230px;
            background-color:red;
        }

        div.contenedor{
            width: 200px;
            height: 230px;
            float: left;
            border-bottom: solid 5px black;
            -webkit-transition: height .4s;
        }

        div#uno{
            background-color: #FB0000;
        }

        div#dos{
            background-color: #EB0000;
        }

        div#tres{
            background-color: #DB0000;
        }

        div#cuatro{
            background-color:#CB0000 ;
        }

        div#cinco{
            background-color:#BB0000;
        }

        div#seis{
            background-color: #AB0000;
        }

        p.texto{
            font-size:1.2em;
            color:white;
            opacity: 0.75;
            text-align: center;
            padding-top:100px ;
            padding-bottom:100px;
            -webkit-transition: font-weight .2s;
            -webkit-transition: padding-top .4s;
            transition-duration: font-weight 2s;
    
        }

        div.contenedor:hover{
            height:250px;
        }

        div.contenedor:hover p.texto{
            padding-top: 115px;
            font-weight: 5px;
            font-size:1.5em;
            opacity: 1;
        }

        footer{
            color:white;
            text-align: center;
            font-size:0.8em;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        div a
        {
            text-decoration:none;
        }
    </style>
</head>
<body>
    <header>
        <div class="contenedor" id="uno">
            <a class="link" href="/../Empleado/Index" ><p class="texto">EMPLEADO</p></a>
        </div>
        <div class="contenedor" id="dos">
            <a class="link" href="/../Curso/Index" ><p class="texto">CURSO</p></a>
        </div>
        <div class="contenedor" id="tres">
            <a class="link" href="/../Tema/Index" ><p class="texto">TEMA</p></a>
        </div>
        <div class="contenedor" id="cuatro">
            <a class="link" href="/../Video/Index" ><p class="texto">VIDEO</p></a>
        </div>
        <div class="contenedor" id="cinco">
            <a class="link" href="/../Curso_Tema/Index" ><p class="texto">CURSO_TEMA</p></a>
        </div>
        <div class="contenedor" id="seis">
            <a class="link" href="/../Curso_Tema_Video/Index" ><p class="texto">CURSO_TEMA<br/>VIDEO</p></a>
        </div>
    </header>
    <footer>Creado por: Tim Umizumi</footer>
</body>
</html>
