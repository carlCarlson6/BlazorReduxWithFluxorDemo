﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo2.Models.Todos
{
    public class TodoDto
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public bool Completed { get; set; }

        public int UserId { get; set; }
    }
}
