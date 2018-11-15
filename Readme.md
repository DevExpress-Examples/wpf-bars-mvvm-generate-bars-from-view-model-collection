<!-- default file list -->
*Files to look at*:

* [BarTemplateSelector.cs](./CS/DXSample/Common/BarTemplateSelector.cs) (VB: [BarTemplateSelector.vb](./VB/DXSample/Common/BarTemplateSelector.vb))
* [MainViewModel.cs](./CS/DXSample/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/DXSample/ViewModels/MainViewModel.vb))
* **[MainView.xaml](./CS/DXSample/Views/MainView.xaml) (VB: [MainView.xaml](./VB/DXSample/Views/MainView.xaml))**
<!-- default file list end -->
# How to build a Bar UI from a ViewModel collection in an MVVM application


<p>In this example, we demonstrated a possible way of using DXBars in MVVM applications - populating bars from a ViewModel collection. This approach assumes setting <strong>...Source</strong> properties for the required bar elements and configuring item properties using either <strong>implicit data templates</strong> or templates/template selectors explicitly assigned using the <strong>...Template</strong> and <strong>...TemplateSelector</strong> properties.<br><br>Another approach is to configure item properties in XAML and bind their properties to your ViewModel - see <a href="https://www.devexpress.com/Support/Center/p/T186664">How to: Create Bars Represented by Separate Containers Using ToolBarControl, MainMenuControl and StatusBarControl</a> for more information.<br><br>See also:<br><a href="https://documentation.devexpress.com/WPF/10434/Controls-and-Libraries/Ribbon-Bars-and-Menu/Common-Concepts/MVVM-Support"> WPF Controls > Controls and Libraries > Ribbon, Bars and Menu > Common Features > MVVM Support</a></p>

<br/>


