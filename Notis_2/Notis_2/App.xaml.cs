using Notis_2.Database;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notis_2
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friends.db";
        public static NoticeRepository database;
        public static NoticeRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoticeRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
