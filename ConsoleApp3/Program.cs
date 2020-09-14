using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var filteredDocument = mongo.getDocumentByNumberControl<Alumno>("alumnos", "_numberControl", 171000264);
            Console.WriteLine(filteredDocument._name);


            var filterDocuments = mongo.getFilteredDocuments<Alumno>("alumnos", "_career", "sistemas");
            foreach(var student in filterDocuments)
            {
                Console.WriteLine(student._name);
            }

    */
            //mongo.insertDocument<Genero>("genero", new Genero("Masculino"));

            Genero genderDocument;
            Carrera careerDocument;

            /*
            mongo.insertDocument<Genero>("generos", new Genero("Masculino"));
            mongo.insertDocument<Genero>("generos", new Genero("Femenino"));

            mongo.insertDocument<Carrera>("Carreras", new Carrera("Ing.Sistemas"));
            mongo.insertDocument<Carrera>("Carreras", new Carrera("Ing.Naval"));
            */

            /**
           genderDocument = mongo.getDocumentByName<Genero>("generos", "Gender", "Masculino");
            careerDocument = mongo.getDocumentByName<Carrera>("Carreras", "Name", "Ing.Sistemas");



            mongo.insertDocument<Alumno>("alumnos",
              new Alumno(171212, "Gabo", "Arce", "Higuera", "Pradera", careerDocument, genderDocument));
            

            


        


            /*
            Alumno alumno;
            alumno = mongo.getDocumentByNumberControl<Alumno>("alumnos", "_numberControl", 171000264);
            */

            //mongo.insertDocument<Visita>("visitas",
            // new Visita(new Usuario(new Alumno(171000264,"Juan", "Antonio", "Cantu", "Pradera", new Carrera("Ing.Sistemas"), new Genero("Masculino")))));

            mongo.insertDocument<Visita>("visitas",
                new Visita(new Alumno(17, "Francisco", "Acosta", "virgen", "pradera",
                new Carrera("ing.siustemas"), new Genero("masculino"))));
            

                        
                        



            Console.ReadKey();
        }




    }
}

