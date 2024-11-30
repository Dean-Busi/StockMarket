using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace api.Dtos
{
    public class CreateStockDto
    {
        [Required]
        [MaxLength(19, ErrorMessage = "Symbol cannot be over 10 characters.")]
        public string Symbol { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        public string Industry { get; set; } = string.Empty;

        public decimal Price { get; set; }
        
        public decimal LastDiv { get; set; }
    }
}

