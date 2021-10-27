using AssetRegistry.Model;

namespace AssetRegistry.ViewModel
{
    class EntryPageViewModel
    {
        public string Description { get; set; }
        public string Make { get; set; }
        public string SerialNumber { get; set; }
        public string Value { get; set; }

        public void AddToItems()
        {
            Item item = new Item();
            item.Description = Description;
            item.Make = Make;
            item.SerialNumber = SerialNumber;
            item.Value = "$"+Value;
            App.Database.SaveItemAsync(item);
        }
        
    }
}
