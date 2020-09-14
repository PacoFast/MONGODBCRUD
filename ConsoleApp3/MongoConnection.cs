using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApp3
{
    class MongoConnection
    {
        IMongoDatabase database;

        public MongoConnection(string urlConnection, string databaseName)
        {
            if (String.IsNullOrWhiteSpace(urlConnection) || String.IsNullOrWhiteSpace(databaseName))
                throw new ArgumentException("La url de conexion o el nombre de la base de datos deben ser proporcionado");
            MongoClient mongo = new MongoClient(urlConnection);
            database = mongo.GetDatabase(databaseName); 
        }
        

        /**
         * Insertar un documento a la coleccion 
         * @collection nombre de la coleccion 
         * @ T document recibe una clase generica en este caso un modelo ya sea Alumno
         * */
        public void insertDocument<T>(string collection, T document)
        {
            if (String.IsNullOrWhiteSpace(collection))
                throw new ArgumentException("El nombre de la colección debe ser proporcionado");
            var studentCollection = database.GetCollection<T>(collection);
            studentCollection.InsertOne(document);
        }

        /*OBTENER TODOS LOS DOCUMENTOS DE UNA COLLECTION CON EL NOMBRE DE LA COLLECTION*/
        public List<T> getAllDocuments<T>(string collection)
        {
            if (String.IsNullOrWhiteSpace(collection))
                throw new ArgumentException("El nombre de la colección debe ser proporcionado");
            var studentsCollection = database.GetCollection<T>(collection);
            return studentsCollection.Find(new BsonDocument()).ToList<T>(); 
        }

        /**
         * OBTENER UNA LISTA DE LA COLECCION FILTRADA
         * @collection nombre de coleccion
         * @field campo example: "_career"
         * @param parametro a buscar
         * */
        public List<T> getFilteredDocuments<T>(string collection, string field, string param)
        {
            if (String.IsNullOrWhiteSpace(collection) || String.IsNullOrWhiteSpace(field) || String.IsNullOrWhiteSpace(param))
                throw new ArgumentException("El nombre, campo o parametro de busqueda deben ser proporcionado");
            var studentCollection = database.GetCollection<T>(collection);
            var filter = Builders<T>.Filter.Eq(field, param);
            return studentCollection.Find(filter).ToList<T>(); 
        }

        /**
         * Obtener documentos por numero de control
         * @collection nombre de la coleccion "alumnos" por ejemplo
         * @field el campo en este caso seria _numberControl, se llama así por el modelo alumno
         * @numberControl el numero de control a buscar
         * */
        public T getDocumentByNumberControl<T>(string collection, string field, int numberControl)
        {
            if (String.IsNullOrWhiteSpace(collection) || String.IsNullOrWhiteSpace(field))
                throw new ArgumentException("El nombre, campo o parametro de busqueda deben ser proporcionado");
            var studentCollection = database.GetCollection<T>(collection);
            var filter = Builders<T>.Filter.Eq(field, numberControl );
            return studentCollection.Find(filter).First(); 
        }

        public T getDocumentByName<T>(string collection, string field, string param)
        {
            if (String.IsNullOrWhiteSpace(collection) || String.IsNullOrWhiteSpace(field) || String.IsNullOrWhiteSpace(param))
                throw new ArgumentException("El nombre, campo o parametro de busqueda deben ser proporcionado");
            var document = database.GetCollection<T>(collection);
            var filter = Builders<T>.Filter.Eq(field, param);
            return document.Find(filter).First();
        }










        

    








    }
}
