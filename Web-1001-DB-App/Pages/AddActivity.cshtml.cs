using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web_1001_DB_Models;
using Web_1001_DB_TodoContext;

namespace Web_1001_DB_App.Pages
{
    public class AddActivityModel : PageModel
    {
  
        private readonly TodoContext _db;

        [FromForm]
        public Todo todo { get; set; }

        public AddActivityModel(TodoContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
         
        }
        public void OnPost()
        {
            _db.Add<Todo>(todo);
            _db.SaveChangesAsync();
        }
    }
}
