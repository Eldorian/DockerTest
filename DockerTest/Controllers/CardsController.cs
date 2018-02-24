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

            return Ok(cards);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cards = repo.GetById(id);
            return Ok(cards);
        }

        [HttpPost]
        public IActionResult Add([FromBody]CardsModel card)
        {
            repo.Add(card);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]CardsModel model)
        {
            repo.Update(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repo.Delete(id);
            return Ok();
        }
    }

}
