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
using ControlMoneyApp.Entity;
using ControlMoneyApp.Data;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ControlMoneyApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddNewMoneyPage : Page
    {
        private string checkedCalendarDatePicker;
        private string categoryInput;
        public AddNewMoneyPage()
        {
            this.InitializeComponent();
        }

        private void SaveNewTransactionClick(object sender, RoutedEventArgs e)
        {
            var newTran = new MyTransaction{
                name = nameInput.Text,
                money = double.Parse(moneyInput.Text),
                datepay = DateTime.Parse(checkedCalendarDatePicker),
                category = categoryInput
            };
            DBinitialize.SaveNewTransaction(newTran);
        }

        private void dateInput_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            CalendarDatePicker cdp = sender as CalendarDatePicker;
            checkedCalendarDatePicker = cdp.Date.Value.ToString("dd-MM-yyyy");
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem menuFlyoutItem = sender as MenuFlyoutItem;
            switch (menuFlyoutItem.Tag)
            {
                case "1":
                    categoryInput = "sinh hoạt phí";
                    break;
                case "2":
                    categoryInput = "tiêu vặt";
                    break;
                case "3":
                    categoryInput = "tặng biếu";
                    break;
            }
        }
    }
}
