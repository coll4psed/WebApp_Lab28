using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace WebApp_Lab28.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost(string userName, string password)
        {
            MySqlConnection conn = new MySqlConnection("server=sutct.org;user=1_08;database=1_08;port=3306;password=8HIzHoFkAh6");
            conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "SELECT * FROM user_info WHERE Nickname=" + userName;
                cmd.CommandText = sql;
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {

            }
            conn.Close();
        }
    }
}
