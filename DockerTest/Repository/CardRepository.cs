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

        public IEnumerable<CardModel> GetAll()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<CardModel>("Select * FROM Cards");
            }
        }
    }
}
