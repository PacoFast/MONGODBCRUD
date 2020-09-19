using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [BsonDiscriminator("Maestro")]
    class Maestro
    {
        public ObjectId id { get; set; }
        public List<Departamento> departamento;

        public Maestro(List<Departamento> departamento)
        {
            this.departamento = departamento;
        }

        public Maestro() { }

    }
}
