using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Models;

namespace api.Mappers
{
    public static class StockMapper
    {

        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Industry = stockModel.Industry,
                Price = stockModel.Price,
                LastDiv = stockModel.LastDiv,
                Comments = stockModel.Comments.Select(c => c.ToCommentDto()).ToList()
            };
        }
        
        public static Stock ToStockFromCreateDto(this CreateStockDto createStockDto)
        {
            return new Stock
            {
                Symbol = createStockDto.Symbol,
                CompanyName = createStockDto.CompanyName,
                Industry = createStockDto.Industry,
                Price = createStockDto.Price,
                LastDiv = createStockDto.LastDiv,
            };
        }

        public static Stock ToStockFromUpdateDto(this UpdateStockDto updateStockDto)
        {
            return new Stock
            {
                Symbol = updateStockDto.Symbol,
                CompanyName = updateStockDto.CompanyName,
                Industry = updateStockDto.Industry,
                Price = updateStockDto.Price,
                LastDiv = updateStockDto.LastDiv,
            };
        }
    }
}
