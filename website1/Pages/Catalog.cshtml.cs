using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;

namespace website1.Pages
{
    public class CatalogModel : PageModel
    {
        public List<House> houses { get; set; }
        public void OnGet()
        {
            NpgsqlConnection connection = new NpgsqlConnection("User ID=user1;Password=changeme;Host=130.193.55.186;Port=5432;Database=tododb;");
            try
            {
                houses = connection.Query<House>("SELECT * FROM \"WebSite1\"").ToList();
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
