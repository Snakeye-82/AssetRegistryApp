using AssetRegistry.Data;
using AssetRegistry.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AssetRegistry
{
    public partial class App : Application
    {
        static ItemDatabase database;
        public static ItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ItemDatabase
                    (DependencyService.Get<IFileHelper>().GetLocalFilePath("ItemSQLite.db3"));
                }
                return database;
            }
        }
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EntryPage());
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
