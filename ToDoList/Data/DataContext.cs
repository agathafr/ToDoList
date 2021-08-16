using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ToDoListConn")
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}