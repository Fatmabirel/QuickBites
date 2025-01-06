using Newtonsoft.Json;

namespace WebUI.Dtos.FoodDtos
{
    public class FoodTastyApi
    {
        public List<ResultFoodDto> Results { get; set; }
    }
    public class ResultFoodDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("total_time_minutes")]
        public int TotalTime { get; set; }
    }
}
