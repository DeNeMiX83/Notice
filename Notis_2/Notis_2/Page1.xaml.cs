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
    public partial class Page1 : ContentPage
    {
        ContentPage parent;
        public Page1()
        {
            InitializeComponent();
        }

       
        public Page1(ContentPage par)
        {
            InitializeComponent();
            parent = par;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            (parent as MainPage).AddElem(new Notification { Time = "e", Opisanie = "s" });
            var _time = Convert.ToString(Time.Time);
            var _description_full = opisanie_1.Text;
            var _description_short = opisanie.Text;
            var _date = D.Date;
            Notices model = new Notices
            {
                time = _time,
                description = _description_short,
                description_full = _description_full,
                date = _date

            };
            App.Database.SaveItem(model); 
            await Navigation.PopAsync(false);
        }
    }
}