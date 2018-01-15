using DockerTest.Models;
using DockerTest.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DockerTest.Controllers
{
    [Route("api/[controller]")]
    public class CardsController : Controller
    {
        private readonly ICardRepository repo;

        public CardsController(ICardRepository repository)
        {
            repo = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cards = repo.GetAll();

            return new ObjectResult(cards);
        }

        [HttpPost]
        public IActionResult Add(CardsModel card)
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
