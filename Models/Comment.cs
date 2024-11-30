using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public int? StockId { get; set; } //Fremdschlüssel

        public Stock? Stock { get; set; } // Navigation Property

        public string UserId { get; set; } = string.Empty;

        public User? User { get; set; }
    }
}

