﻿

#pragma checksum "C:\Users\osar\Documents\Visual Studio 2012\Projects\SaveTheHumans\SaveTheHumans\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A9CEDC6C625867F577F2E5B71832449A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaveTheHumans
{
    partial class MainPage : global::SaveTheHumans.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 91 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.startButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 97 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerMoved += this.playArea_PointerMoved;
                 #line default
                 #line hidden
                #line 97 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerExited += this.playArea_PointerExited;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 104 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.human_PointerPressed;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 109 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerEntered += this.target_PointerEntered;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 88 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


