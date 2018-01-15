using DockerTest.Models;
using System.Collections.Generic;

namespace DockerTest.Repository
{
    public interface ICardRepository
    {
        IEnumerable<CardModel> GetAll();
    }
}
