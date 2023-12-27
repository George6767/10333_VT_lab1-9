using System.Text.Json.Serialization;

namespace Laba1Sol.Blazor.Data
{
    public class ListViewModel
    {
        [JsonPropertyName("dishId")]
        public int DishId { get; set; } 
        [JsonPropertyName("dishName")]
        public string DishName { get; set; } 
    }
    public class DetailsViewModel
    {
        [JsonPropertyName("dishName")]
        public string DishName { get; set; } 
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("calories")]
        public int Calories { get; set; } 
        [JsonPropertyName("image")]
        public string Image { get; set; } 
    }
}
