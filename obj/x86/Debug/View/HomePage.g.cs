#pragma checksum "F:\01. Universal App\SQLIte_Practice_UWP_ki3\View\HomePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "82A81D39A6F8161259F0D7BECA974B68D868954BEF8B61AA0704353198930763"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlMoneyApp.View
{
    partial class HomePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\HomePage.xaml line 11
                {
                    this.nvMain = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                }
                break;
            case 3: // View\HomePage.xaml line 14
                {
                    global::Windows.UI.Xaml.Controls.NavigationViewItem element3 = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)element3).Tapped += this.AddNewCLick;
                }
                break;
            case 4: // View\HomePage.xaml line 15
                {
                    global::Windows.UI.Xaml.Controls.NavigationViewItem element4 = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)element4).Tapped += this.ShowAllClick;
                }
                break;
            case 5: // View\HomePage.xaml line 17
                {
                    this.contentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

