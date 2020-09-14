using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Carrera
    {
        

        private string name;

        public Carrera(string name)
        {
            this.name = name;
        }


        public string Name { get => name; set => name = value; }

    }
}
