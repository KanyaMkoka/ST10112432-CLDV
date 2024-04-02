using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CLDV.Models
{
    public class userTable : Controller
    {
        public static string con_string = "Server=tcp:part1-sql-server.database.windows.net,1433;Initial Catalog = cldv - sql - db; Persist Security Info=False;User ID = Kay; Password= 20 September 1997!*; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
    
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(con_string);
        
        public String Name { get; set; }

        public String ID { get; set; }    
        public IActionResult Index()
        {
            return View();
        }
    }
}
