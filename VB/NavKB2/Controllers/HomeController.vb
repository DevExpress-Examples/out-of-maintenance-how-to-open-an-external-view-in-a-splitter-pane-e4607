Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Mvc

Namespace NavKB2.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function ShowFirst() As ActionResult
			Return View("SampleView1")
		End Function
		Public Function ShowSecond() As ActionResult
			Return View("SampleView2")
		End Function
	End Class
End Namespace