using Microsoft.AspNetCore.Mvc;
using CandyFactoryApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace CandyFactoryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandiesController : ControllerBase
    {
        private static List<Candy> _candyArray = new List<Candy>
        {
            new Candy { Id = 1, Name = "Каракум", PricePerKg = 250 },
            new Candy { Id = 2, Name = "Червоний мак", PricePerKg = 310 },
            new Candy { Id = 3, Name = "Ромашка", PricePerKg = 180 }
        };

        [HttpGet]
        public ActionResult<List<Candy>> GetAllCandies()
        {
            return Ok(_candyArray);
        }

        [HttpPost]
        public ActionResult<Candy> AddCandy(Candy newCandy)
        {
            int newId = _candyArray.Any() ? _candyArray.Max(c => c.Id) + 1 : 1;
            newCandy.Id = newId;
            _candyArray.Add(newCandy);
            return Ok(newCandy);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCandy(int id)
        {
            var candyToDelete = _candyArray.FirstOrDefault(c => c.Id == id);
            if (candyToDelete == null) return NotFound("Цукерки не знайдені.");

            _candyArray.Remove(candyToDelete);
            return Ok($"Запис ID: {id} успішно видалено.");
        }

        [HttpGet("search/{query}")]
        public ActionResult<List<Candy>> SearchCandy(string query)
        {
            var results = _candyArray
                .Where(c => c.Name.ToLower().Contains(query.ToLower()))
                .ToList();

            if (!results.Any()) return NotFound("Нічого не знайдено.");
            return Ok(results);
        }
    }
}