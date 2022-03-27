using System;
using Microsoft.EntityFrameworkCore;
using Web_1001_DB_Models;

namespace Web_1001_DB_TodoContext
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options) { }
        public DbSet<Todo> Todos { get; set; }
    }
}
