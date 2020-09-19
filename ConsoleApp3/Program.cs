using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static MongoConnection mongo;

        static void Main(string[] args)
        {




            mongo = new MongoConnection("mongodb://localhost:27017", "tec");
            
            /*
            mongo.insertDocument<Carrera>("carreras", new Carrera("Ing.Sistemas"));

            mongo.insertDocument<Genero>("generos", new Genero("Masculino"));
            */

            Carrera carrera = mongo.getDocumentByName<Carrera>("carreras", "name", "Ing.Sistemas");

            Genero genero = mongo.getDocumentByName<Genero>("generos", "name", "Masculino");


            //mongo.insertDocument<Alumno>("alumnos", new Alumno("171000264", carrera));

            Alumno alumno = mongo.getDocumentByName<Alumno>("alumnos", "numberControl", "171000264");

            /** INSERTANDO USUARIO
            mongo.insertDocument<Usuario>("usuarios",
                new Usuario
                {
                    name = "Francisco",
                    surname = "Acosta", 
                    secondSurname ="Virgen",
                    rol = 1, 
                    student = alumno
                }
            );
            */

            Usuario usuario = mongo.getDocumentByName<Usuario>("usuarios", "name", "Francisco");

            Console.WriteLine($"{usuario.name} tiene el numero de control {usuario.student.numberControl}");

            //mongo.insertDocument<Visita>("visitas", new Visita(usuario));

            var query = from visitas in mongo.getAllDocuments<Visita>("visitas")
                        where visitas.user.name == "Francisco"
                        select new { visitas.user.student.numberControl, visitas.date, visitas.user.name };


            foreach(var documentos in query)
            {

                Console.WriteLine($"{documentos.name} entro en la fecha: {documentos.date.ToLocalTime()}" +
                    $" y tiene el numero de control de: {documentos.numberControl}");
            }


            Console.WriteLine("HECHO!");


            Console.ReadKey();
        }




    }
}

