using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Todo.Models
{
    internal class TodoItem
    {

        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public bool Done { get; set; }

    }
}
