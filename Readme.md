<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128640584/23.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T246650)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Bars - Generate Bar Items from a View Model Collection in an MVVM Application

This example demonstrates how to generate bars (main menu and status bar) and bar items ([BarButtonItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarButtonItem), [BarSubItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarSubItem), [BarItemSeparator](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarItemSeparator), and [BarStaticItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarStaticItem)) from a View Model collection:

![image](https://github.com/DevExpress-Examples/how-to-build-a-bar-ui-from-a-viewmodel-collection-in-an-mvvm-application-t246650/assets/65009440/243f8df0-0d44-40c9-b443-3ba807ee30bd)

Each bar container has **\*Source**, **\*Template**, and **\*TemplateSelector** properties. The **\*Source** property specifies a View Model collection that contains objects used to generate child bar items. **\*Template** and **\*TemplateSelector** properties specify a data template that generates items from the specified collection. Refer to the following help topic for a complete list of properties: [WPF Ribbon, Bars, and Menu: MVVM Support](https://docs.devexpress.com/WPF/10434/controls-and-libraries/ribbon-bars-and-menu/common-concepts/mvvm-support).

## Implementation Details

This project contains View Models used to generate different bar items:

* **BarViewModel** - describes a bar (main menu and status bar) that stores bar items.
* **BarItemViewModelBase** - describes a [BarItemSeparator](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarItemSeparator).
* **StaticBarItemViewModel** - describes a [BarStaticItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarStaticItem).
* **BarItemViewModel** - describes a [BarButtonItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarButtonItem).
* **GroupBarItemViewModel** - describes a [BarSubItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarSubItem).

```cs
public class BarItemViewModel : StaticBarItemViewModel {

    Action<string> action;

    public BarItemViewModel(Action<string> action, string caption = null, Uri glyph = null) {
        this.Caption = caption;
        this.action = action;
        this.Glyph = glyph;
    }

    [Command]
    public void ExecuteAction(string parameter) {
        if (action != null) {
            action(parameter);
        }
    }

    public Uri Glyph {
        get { return this.GetValue<Uri>(); ; }
        set { this.SetValue(value); }
    }

}
```

The **MainViewModel** class includes the **Bars** collection that consists of View Model class objects:

```cs
public class MainViewModel : ViewModelBase {
    public ObservableCollection<BarViewModel> Bars { get; set; }
    // ...
}
```

The **MainWindow** class contains implicit data templates associated with View Model classes. These templates are applied to each generated object of the specified type:

```xaml
<DataTemplate DataType="{x:Type ViewModels:BarItemViewModel}">
    <ContentControl>
        <dxb:BarButtonItem 
            Content="{Binding Caption}"
            Glyph="{Binding Glyph}"
            GlyphAlignment="Top"
            BarItemDisplayMode="ContentAndGlyph"
            Command="{Binding ExecuteActionCommand}"
            CommandParameter="{Binding Caption}"/>
    </ContentControl>
</DataTemplate>
```

The [BarManager.BarsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarManager.BarsSource) property is bound to the **Bars** View Model collection.

## Files to Review

* [MainViewModel.cs](./CS/DXSample/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/DXSample/ViewModels/MainViewModel.vb))
* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))
* [BarTemplateSelector.cs](./CS/DXSample/Common/BarTemplateSelector.cs) (VB: [BarTemplateSelector.vb](./VB/DXSample/Common/BarTemplateSelector.vb))

## Documentation

* [WPF Ribbon, Bars and Menu: MVVM Support](https://docs.devexpress.com/WPF/10434/controls-and-libraries/ribbon-bars-and-menu/common-concepts/mvvm-support)
* [The List of Bar Items and Links](https://docs.devexpress.com/WPF/6646/controls-and-libraries/ribbon-bars-and-menu/common-concepts/the-list-of-bar-items-and-links)

## More Examples

* [MVVM Application with WPF Bars](https://github.com/DevExpress-Examples/mvvm-application-with-wpf-bars)
* [WPF Bars - Use ToolBarControl, MainMenuControl, and StatusBarControl Containers](https://github.com/DevExpress-Examples/how-to-create-bars-using-toolbarcontrol-mainmenucontrol-and-statusbarcontrol-t186664)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-bars-mvvm-generate-bars-from-view-model-collection&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-bars-mvvm-generate-bars-from-view-model-collection&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
