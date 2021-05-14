# TabViewSampleError

Binding error on views inside a TabViewItem if the TabView page itself has a Binding defined

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    x:Class="TabViewSample.MainPage"
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:views1="clr-namespace:TabViewSample.Views;assembly=TabViewSample"
    xmlns:xct="http://xamarin.com/schemas/2020/toolkit"
    BindingContext="{Binding MainViewModel, Source={StaticResource Locator}}">
    <!--  if delete BindingContext into this MainPage, the binding work into LazyView otherwise don't work  -->
    <Grid>
        <xct:TabView
            TabStripBackgroundColor="Blue"
            TabStripHeight="50"
            TabStripPlacement="Bottom">
            <xct:TabViewItem Text="One" TextColor="White">
                <xct:LazyView x:TypeArguments="views1:OneView" BindingContext="{Binding OneView, Source={StaticResource Locator}}" />
            </xct:TabViewItem>
            <xct:TabViewItem Text="Two" TextColor="White">
                <xct:LazyView x:TypeArguments="views1:TwoView" BindingContext="{Binding TwoView, Source={StaticResource Locator}}" />
            </xct:TabViewItem>
        </xct:TabView>
    </Grid>
</ContentPage>

```
