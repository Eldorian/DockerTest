using Dapper;
using DockerTest.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DockerTest.Repository
{
    public class CardRepository : ICardRepository
    {
        private readonly IConfiguration Configuration;
        private readonly IDbConnection db;

        public CardRepository(IConfiguration config)
        {
            db = new SqlConnection(config.GetConnectionString("DefaultConnection"));
        }

        public IEnumerable<CardsModel> GetAll()
        {
            var sql = @"SELECT * FROM CARDS";

            return db.Query<CardsModel>(sql);
        }

        public CardsModel GetById(int id)
        {
            var sql = @"SELECT * FROM CARDS WHERE Id = @id";

            return db.Query<CardsModel>(sql, new CardsModel {Id = id}).SingleOrDefault();
        }

        public void Add(CardsModel model)
        {
            var sql =
                "INSERT INTO CARDS (Name, ManaCost, Attack, Health, Rarity, SetName) VALUES (@Name, @ManaCost, @Attack, @Health, @Rarity, @SetName)";

            db.Query<CardsModel>(sql, model);
        }

        public void Update(int id, CardsModel model)
        {
            var sql =
                "UPDATE CARDS SET Name = @Name, ManaCost = @ManaCost, Attack = @Attack, Health = @Health, Rarity = @Rarity, SetName = @SetName WHERE id = @id";

            db.Query<CardsModel>(sql, model);
        }

        public void Delete(int id)
        {
            var sql = "DELETE FROM CARDS WHERE ID = @id";

            db.Query<CardsModel>(sql, new CardsModel{Id = id});
        }
    }
}
