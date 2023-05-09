﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.models {
    public abstract class Person 
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public override string ToString() {
            return FirstName + " " + LastName;
        }
    }
}
