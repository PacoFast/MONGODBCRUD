using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Departamento
    {
        [BsonId]
        private Guid id;
        private string name;


        public Departamento(string name)
        {
            this.name = name; 
        }

        public Guid Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
