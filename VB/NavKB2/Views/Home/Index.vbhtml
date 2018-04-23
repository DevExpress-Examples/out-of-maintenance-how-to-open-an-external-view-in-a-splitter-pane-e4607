@Code
    ViewBag.Title = "Home Page"
End Code


@Html.DevExpress().Splitter( _
    Sub(settings)
            settings.Name = "Splitter"
            settings.FullscreenMode = True
            settings.Height = System.Web.UI.WebControls.Unit.Percentage(100)
            settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
            settings.AllowResize = True
            settings.Panes.Add( _
                Sub(pane)
                        pane.AutoWidth = True
                        pane.SetContent( _
                            Sub()
                                    Html.DevExpress().TreeView( _
                                        Sub(treeSettings)
                                                treeSettings.Name = "TreeView"
                                                treeSettings.AllowSelectNode = False
                                                treeSettings.Target = "NavigationIframe"

                                                treeSettings.Nodes.Add( _
                                                    Sub(node)
                                                            node.Text = "First"
                                                            node.NavigateUrl = Url.Action("ShowFirst")
                                                    End Sub)
                                                treeSettings.Nodes.Add( _
                                                    Sub(node)
                                                            node.Text = "Second"
                                                            node.NavigateUrl = Url.Action("ShowSecond")
                                                    End Sub)
                                        End Sub).Render()
                            End Sub)
                End Sub)
            settings.Panes.Add( _
                    Sub(pane)
                            pane.ContentUrl = "about:blank"
                            pane.ContentUrlIFrameName = "NavigationIframe"
                    End Sub)
    End Sub).GetHtml()



