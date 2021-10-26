using AssetRegistry.ViewModel;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AssetRegistry.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        EntryPageViewModel vm;
        

        public EntryPage()
        {
            InitializeComponent();
            vm = new EntryPageViewModel();
            BindingContext = vm;
        }
        

        private void AddEntry(object sender, EventArgs e)
        {
            if (vm.Description == null)
            {
                DisplayAlert("Error", "Please Enter a Description to continue", "Ok");
            }
            else
            {
                vm.AddToItems();
                DisplayAlert("Added", "Item successfully added.", "OK");
            }
            

        }
        private void ViewList(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        
    }
}