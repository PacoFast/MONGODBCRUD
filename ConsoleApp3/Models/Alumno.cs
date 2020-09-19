using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [BsonDiscriminator("Alumno")]
    class Alumno
    {
        public ObjectId id { get; set; }
        
        public string numberControl { get; set; }

        public Carrera carrera { get; set; }

        public Alumno() { }

        public Alumno(string numberControl, Carrera carrera)
        {
            this.numberControl = numberControl;
            this.carrera = carrera;
        }
    }
}
