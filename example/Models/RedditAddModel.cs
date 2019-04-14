using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace example.Models
{
    public class RedditAddModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SelectedCategory { get; set; }
        public string SelectedApplication { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Applications { get; set; }
    }
}
