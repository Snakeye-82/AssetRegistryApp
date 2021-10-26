using SQLite;

namespace AssetRegistry.Model
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public string Make { get; set; }
        public string SerialNumber { get; set; }

        public string Value { get; set; }
        

        
    }
}
