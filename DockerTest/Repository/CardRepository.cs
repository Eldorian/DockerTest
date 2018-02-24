using Dapper;
using DockerTest.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DockerTest.Repository
{
    public class CardRepository :  ICardRepository
    {
        private readonly IConfiguration Configuration;
        private string connectionString;
        public CardRepository(IConfiguration config)
        {
            connectionString = config.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<CardsModel> GetAll()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sql = @"SELECT * FROM CARDS";

                return db.Query<CardsModel>(sql);
            }
        }
    }
}
