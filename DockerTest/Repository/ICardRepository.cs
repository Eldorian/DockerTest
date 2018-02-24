using DockerTest.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace DockerTest.Repository
{
    public interface ICardRepository
    {
        IEnumerable<CardsModel> GetAll();
        CardsModel GetById(int id);
        void Add(CardsModel model);
        void Update(int id, CardsModel model);
        void Delete(int id);
    }
}
