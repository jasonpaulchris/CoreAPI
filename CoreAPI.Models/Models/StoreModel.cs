namespace CoreAPI.Models
{
    public class StoreModel : BaseModel
    {
        public string Name { get; set; }
        public int NumberOfProducts { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}
