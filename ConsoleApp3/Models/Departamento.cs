using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [BsonDiscriminator("Departamento")]

    class Departamento
    {
        public ObjectId id { get; set; }
        public string name { get; set; }

        public Departamento() { }

        public Departamento(string name)
        {
            this.name = name;
        }
    }
}
