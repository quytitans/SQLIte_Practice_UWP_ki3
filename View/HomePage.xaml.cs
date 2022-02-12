using ControlMoneyApp.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ControlMoneyApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
            this.Loaded += HomePage_Loaded1;
        }

        private void HomePage_Loaded1(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(View.WellcomePage));
            DBinitialize.CreateTable();       
        }

        private void AddNewCLick(object sender, TappedRoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(View.AddNewMoneyPage));
        }

        private void ShowAllClick(object sender, TappedRoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(View.ViewAllDataPage));
        }
    }
}
