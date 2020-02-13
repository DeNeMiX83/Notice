using Notis_2.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notis_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowNotifPage : ContentPage
    {
        public ShowNotifPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            

            base.OnAppearing();
        }
        private void DeleteFriend(object sender, EventArgs e)
        {
            var friend = (Notices)BindingContext;
            App.Database.DeleteItem(friend.Id);
            this.Navigation.PopAsync(false);
        }
    }
}