using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [BsonDiscriminator("Usuario")]
    class Usuario
    {
        public ObjectId id { get; set; }

        public string name { get; set; }
        public string surname { get; set; }
        public string secondSurname { get; set; }
        public int rol { get; set; }

        [BsonIgnoreIfNull]
        public Maestro teacher;
        [BsonIgnoreIfNull]
        public Alumno student;


        public Usuario() { }

        /*COSNTRUCTOR PARA ALUMNOS*/
        public Usuario(string name, string surname, string secondSurname, int rol, Alumno student)
        {
            this.name = name;
            this.surname = surname;
            this.secondSurname = secondSurname;
            this.rol = rol;
            this.student = student;
        }
        /*CONSTRUCTOR PARA MAESTROS*/
        public Usuario(string name, string surname, string secondSurname, int rol, Maestro teacher)
        {
            this.name = name;
            this.surname = surname;
            this.secondSurname = secondSurname;
            this.rol = rol;
            this.teacher = teacher;
        }
    }
}
