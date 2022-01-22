using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerContract.Entities
{
    class Departament
    {
        public string Name { get; set; }

        public Departament() 
        {        
        }

        public Departament(string name) 
        { 
            Name = name;
        }

    }
}


