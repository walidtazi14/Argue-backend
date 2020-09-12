using Newtonsoft.Json;

namespace backend_project.Models
{
    public class Photo
    {
        public int id { get; set; }

        public string url { get; set; }
        [JsonIgnore]
        public User user { get; set; }
        public int UserId { get; set; }
    }
}