using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDBContext _context;
        public StockRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        // POST
        public async Task<Stock> CreateAsync(Stock stockModel)
        {
            await _context.Stocks.AddAsync(stockModel);
            await _context.SaveChangesAsync();
            return stockModel;
        }

        // DELETE
        public async Task<Stock?> DeleteAsync(int id)
        {
            var stockToDelete = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);

            if (stockToDelete == null)
            {
                return null;
            }

            _context.Stocks.Remove(stockToDelete);
            await _context.SaveChangesAsync();
            return stockToDelete;
        }

        // GETALL
        public async Task<List<Stock>> GetAllAsync(QueryObject query)
        {
            var stocks = _context.Stocks.Include(c => c.Comments).ThenInclude(a => a.User).AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.CompanyName))
            {
                stocks = stocks.Where(s => s.CompanyName.Contains(query.CompanyName));
            }

            if (!string.IsNullOrWhiteSpace(query.Symbol))
            {
                stocks = stocks.Where(s => s.Symbol.Contains(query.Symbol));
            }

            if (!string.IsNullOrWhiteSpace(query.SortBy))
            {
                if (query.SortBy.Equals("Symbol", StringComparison.OrdinalIgnoreCase))
                {
                    stocks = query.IsDescending ? stocks.OrderByDescending(s => s.Symbol) : stocks.OrderBy(s => s.Symbol);
                }
            }

            var skipNumber = (query.PageNumber - 1) * query.PageSize;

            return await stocks.Skip(skipNumber).Take(query.PageSize).ToListAsync();
        }

        // GETBYID
        public async Task<Stock?> GetByIdAsync(int id)
        {
            return await _context.Stocks.Include(c => c.Comments).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Stock?> GetBySymbolAsync(string symbol)
        {
            return await _context.Stocks.FirstOrDefaultAsync(s => s.Symbol == symbol);
        }

        // Wird ausgeführt wenn der "POST-COMMENT" Request verwendet wird.
        public Task<bool> StockExists(int id)
        {
            return _context.Stocks.AnyAsync(s => s.Id == id);
        }

        // PUT
        public async Task<Stock?> UpdateAsync(int id, Stock stockModel)
        {
            var stockToUpdate = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);

            if (stockToUpdate == null)
            {
                return null;
            }

            stockToUpdate.Symbol = stockModel.Symbol;
            stockToUpdate.CompanyName = stockModel.CompanyName;
            stockToUpdate.Industry = stockModel.Industry;
            stockToUpdate.Price = stockModel.Price;
            stockToUpdate.LastDiv = stockModel.LastDiv;

            await _context.SaveChangesAsync();

            return stockToUpdate;
        }
    }
}

