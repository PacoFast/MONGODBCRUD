using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [BsonDiscriminator("Carrera")]
    public class Carrera
    {
        public ObjectId id { get; set; }
        public string name { get; set; }

        public Carrera() { }

        public Carrera(string name)
        {
            this.name = name;
        }



    }
}
