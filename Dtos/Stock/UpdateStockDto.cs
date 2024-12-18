using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos
{
    public class UpdateStockDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 characters.")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(20, ErrorMessage = "Company name cannot be over 20 characters.")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [MaxLength(10, ErrorMessage = "Industry cannot be over 10 characters.")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(0.001, 1000000)]
        public decimal Price { get; set; }

        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }
    }
}

