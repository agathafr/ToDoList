using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Tarefa
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public bool? Executada { get; set; }
    }
}