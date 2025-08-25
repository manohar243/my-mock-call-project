namespace Food_delivery.Models.DTO
{
    public class CreateFoodPostRequestDto
    {
        public Guid Order_Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string Customization { get; set; } = string.Empty;
        public int Price { get; set; }

        public string UrlHandle { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.UtcNow;

        public string Master { get; set; } = string.Empty;
        public bool Available { get; set; } = true;
    }
}
