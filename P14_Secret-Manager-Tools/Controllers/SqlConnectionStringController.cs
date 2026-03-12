using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace P14_Secret_Manager_Tools.Controllers
{
    public class SqlConnectionStringController : Controller
    {
        private readonly IConfiguration _configuration;

        public SqlConnectionStringController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {

            var connection = _configuration.GetConnectionString("SQL");
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connection);
            builder.UserID = _configuration["SQL:KullaniciAdi"];
            builder.Password = _configuration["SQL:Sifre"];

            var connectionString = builder.ConnectionString; // Full Connection String

            return View();
        }
    }
}
