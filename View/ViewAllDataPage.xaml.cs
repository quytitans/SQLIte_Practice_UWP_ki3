using ControlMoneyApp.Entity;
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
using ControlMoneyApp.Data;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ControlMoneyApp.View
{
        /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewAllDataPage : Page
    {
        private string FromDate = "";
        private string ToDate = "";
        private string CategoryPick = "";
        int totalMoney = 0;
        public List<MyTransaction> listViewAll { get; set; }
        public ViewAllDataPage()
        {
            
            this.InitializeComponent();
            listViewAll = new List<MyTransaction>();
            listViewAll = DBinitialize.SelectAll();
            foreach (MyTransaction myTransactions in listViewAll)
            {
                totalMoney += (int) myTransactions.money;
            }
            inputGridDataView.ItemsSource = listViewAll;
            totalMoneyView.Text = totalMoney.ToString();
        }

        private void FromDate_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            CalendarDatePicker cdp = sender as CalendarDatePicker;
            if(cdp.Date != null)
            {
                FromDate = cdp.Date.Value.ToString("dd-MM-yyyy");
            }            
        }

        private void ToDate_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            CalendarDatePicker cdp = sender as CalendarDatePicker;
            if (cdp.Date != null)
            {
                ToDate = cdp.Date.Value.ToString("dd-MM-yyyy");
            }            
        }

        private void CategoryClick (object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem menuFlyoutItem = sender as MenuFlyoutItem;
            switch (menuFlyoutItem.Tag)
            {
                case "1":
                    CategoryPick = "sinh hoạt phí";
                    previewCategory.Text = CategoryPick;
                    break;
                case "2":
                    CategoryPick = "tiêu vặt";
                    previewCategory.Text = CategoryPick;
                    break;
                case "3":
                    CategoryPick = "tặng biếu";
                    previewCategory.Text = CategoryPick;
                    break;
            }
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            previewCategory.Text = "";
            CategoryPick = "";
            FromDate = "";
            ToDate = "";
            inputFromDate.Date = null;
            inputToDate.Date = null;
            listViewAll = DBinitialize.SelectAll();
            totalMoney = 0;
            foreach (MyTransaction myTransactions in listViewAll)
            {
                totalMoney += (int)myTransactions.money;
            }
            inputGridDataView.ItemsSource = listViewAll;
            totalMoneyView.Text = totalMoney.ToString();           

        }

        private void ButtonSearch_Click (object sender, RoutedEventArgs e)
        {
            if(CategoryPick != "" || FromDate != "" || ToDate != "")
                {
                    totalMoney = 0;
                    listViewAll = new List<MyTransaction>();
                    listViewAll = DBinitialize.SelectByFilter(CategoryPick, FromDate, ToDate);
                    foreach (MyTransaction myTransactions in listViewAll)
                    {
                        totalMoney += (int)myTransactions.money;
                    }
                    inputGridDataView.ItemsSource = listViewAll;
                    totalMoneyView.Text = totalMoney.ToString();
                }
            }
            
    }
}
