using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos;
using api.Interfaces;
using api.Mappers;
using api.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockRepository _stockRepo;

        // Dependecy Injection
        public StockController(IStockRepository stockRepo)
        {
            _stockRepo = stockRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var stocks = await _stockRepo.GetAllAsync(query);

            var stockDto = stocks.Select(s => s.ToStockDto());

            return Ok(stockDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var stock = await _stockRepo.GetByIdAsync(id);

            if (stock == null)
            {
                return NotFound("Der Eintrag wurde nicht gefunden.");
            }
            
            return Ok(stock.ToStockDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStockDto stockDto)
        {
            var stockToCreate = stockDto.ToStockFromCreateDto();
            await _stockRepo.CreateAsync(stockToCreate);

            return CreatedAtAction(nameof(GetById), new { id = stockToCreate.Id }, stockToCreate.ToStockDto());
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateStockDto updateDto)
        {
            var updatedStockValue = updateDto.ToStockFromUpdateDto();
            var stockToUpdate = await _stockRepo.UpdateAsync(id, updatedStockValue);

            if (stockToUpdate == null)
            {
                return NotFound("Der Eintrag wurde nicht gefunden.");
            }

            return Ok(stockToUpdate.ToStockDto());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var stockToDelete = await _stockRepo.DeleteAsync(id);

            if (stockToDelete == null)
            {
                return NotFound("Der Eintrag wurde nicht gefunden.");
            }

            return Ok("Eintrag wurde gelöscht.");
        }
    }
}



