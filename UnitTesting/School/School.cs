﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        public string Name { get; private set; }

        public School(string name)
        {
            this.Name = name;
        }
    }
}
