using AssetRegistry.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AssetRegistry.ViewModel
{
    class MainPageViewModel
    {

        public ObservableCollection<Item> Items { get; set; } =
            new ObservableCollection<Item>();

        public MainPageViewModel()
        {
            PopulateItems();
        }

        private async void PopulateItems()
        {
            List<Item> items = await App.Database.GetItemsAsync();
            foreach (Item item in items)
            {
                Items.Add(item);
            }
        }

        public async void DeleteItem()
        {
            List<Item> items = await App.Database.GetItemsAsync();
            foreach (Item item in items)
            {
                await App.Database.DeleteItemAsync(item);
            }
            
        }
        
    }

}
