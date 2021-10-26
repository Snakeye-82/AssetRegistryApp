using AssetRegistry.Model;
using AssetRegistry.View;
using AssetRegistry.ViewModel;
using System;
using Xamarin.Forms;


namespace AssetRegistry
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void Back_Button_Clicked(object o, EventArgs e)
        {
            Navigation.PushAsync(new EntryPage());
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Alert", "Are you sure you want to delete all items?", "Yes", "No");
            if (answer == true)
            {
                vm.DeleteItem();
                await Navigation.PushAsync(new EntryPage());
            }
            else { }
            
            
        }

        private void RadioButton1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
                BackgroundColor = Color.White;
               
        }

        
        private void RadioButton2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            BackgroundColor = Color.Gold;
            
        }


    }

}
