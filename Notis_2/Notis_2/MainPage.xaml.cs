using Notis_2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notis_2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<Notification> Notifs = new List<Notification>();
        protected override void OnAppearing()
        {
            Listview.ItemsSource = App.Database.GetItems()         
                .OrderBy(x => x.date);
                
            base.OnAppearing();
        }
        public MainPage()
        { 
            InitializeComponent();  
        }
        private async void Page1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(this), false);
        }

        public void AddElem(Notification notif)
        {
            Notifs.Add(notif);
            Listview.ItemsSource = Notifs;
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if ((sender as ListView).SelectedItem != null)
            {
                (sender as ListView).SelectedItem = null;
                Notices selectedItem = (Notices)e.SelectedItem;
                ShowNotifPage Page = new ShowNotifPage();
                Page.BindingContext = selectedItem;
                await Navigation.PushAsync(Page, false);
            } 
        }
    }
}
