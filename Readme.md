<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/NavKB2/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/NavKB2/Controllers/HomeController.vb))
* [Index.cshtml](./CS/NavKB2/Views/Home/Index.cshtml)
* [SampleView1.cshtml](./CS/NavKB2/Views/Home/SampleView1.cshtml)
* [SampleView2.cshtml](./CS/NavKB2/Views/Home/SampleView2.cshtml)
<!-- default file list end -->
# How to open an external View in a Splitter Pane
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4607/)**
<!-- run online end -->


<p>This example is an illustration of the <a href="https://www.devexpress.com/Support/Center/p/KA18732">KA18732: How to open external Page / View in a Splitter Pane</a> KB Article. Refer to the Article for an explanation.<br />
It demonstrates how to open an external View in a Splitter Pane using navigation extensions.</p><br />
<p>Set the pane's ContentUrl property to "about:blank". This will render the pane as an iframe.</p><p>In addition, set the pane's ContentUrlIFrameName property. This will be the target to open links from the navigation extensions items. Thus, any item's Target property should be equal to the pane's ContentUrlIFrameName property.</p><br />
<p>pane.ContentUrl = "about:blank";</p><p>pane.ContentUrlIFrameName = "NavigationIframe"; </p><p>The item's NavigateUrl property should contain a url to the controller's action that will return the necessary view.</p>

```cs
node.NavigateUrl = Url.Action("ShowFirst");
```

<p> </p>

<br/>


