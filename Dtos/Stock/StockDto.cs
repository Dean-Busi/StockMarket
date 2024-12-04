using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using Microsoft.Identity.Client;
using Microsoft.Net.Http.Headers;

namespace api.Dtos
{
    public class StockDto
    {
        public int Id { get; set; }

        public string Symbol { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        public string Industry { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal LastDiv { get; set; }

        public List<CommentDto> Comments { get; set; }
    }
}

