namespace YarnInventoryWeb.Models
{
    public class YarnItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int InStock { get; set; }
        public int InBag { get; set; }
        public bool IsDiscontinued { get; set; }

        // Creates a deep copy of the item so history states don't share references
        public YarnItem Clone()
        {
            return new YarnItem
            {
                Id = this.Id,
                Title = this.Title,
                Brand = this.Brand,
                InStock = this.InStock,
                InBag = this.InBag,
                IsDiscontinued = this.IsDiscontinued
            };
        }
    }
}