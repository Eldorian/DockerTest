using System.Collections.Generic;
using DockerTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerTest.Controllers
{
    [Route("api/[controller]")]
    public class CardsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var cards = new List<CardModel>();

            cards.Add(new CardModel()
            {
                Id = 1,
                Name = "Ragnaros, Firelord",
                ManaCost = 8,
                Attack = 8,
                Health = 8,
                SetName = "Hall of Fame",
                Rarity = "Legendary"
            });

            cards.Add(new CardModel()
            {
                Id = 2,
                Name = "Call of the Wild",
                ManaCost = 9,
                SetName = "Whispers of the Old Gods",
                Rarity = "Epic"
            });

            cards.Add(new CardModel()
            {
                Id = 3,
                Name = "Corridor Creeper",
                ManaCost = 7,
                Attack = 5,
                Health = 5,
                SetName = "Kobolds and Catacombs",
                Rarity = "Epic"
            });

            return new ObjectResult(cards);
        }

        [HttpPost]
        public IActionResult Add(CardModel card)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
