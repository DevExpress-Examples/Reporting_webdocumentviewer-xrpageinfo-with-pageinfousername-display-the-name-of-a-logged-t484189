﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function


    Function Viewer() As ActionResult
        Return View()
    End Function
End Class