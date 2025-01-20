using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos
{
    public class UpdateStockDto
    {
        [Required(ErrorMessage = "Bitte fülle dieses Feld aus.")]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 characters.")]
        public string? Symbol { get; set; }

        [Required(ErrorMessage = "Bitte fülle dieses Feld aus.")]
        [MaxLength(20, ErrorMessage = "Company name cannot be over 20 characters.")]
        public string? CompanyName { get; set; }

        [Required(ErrorMessage = "Bitte fülle dieses Feld aus.")]
        [MaxLength(20, ErrorMessage = "Industry cannot be over 20 characters.")]
        public string? Industry { get; set; }

        [Required(ErrorMessage = "Bitte fülle dieses Feld aus.")]
        [Range(0.001, 1000000, ErrorMessage = "Range must be between 0.001 and 1000000.")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Bitte fülle dieses Feld aus.")]
        [Range(0.001, 100, ErrorMessage = "Range must be between 0.001 and 100.")]
        public decimal? LastDiv { get; set; }
    }
}

