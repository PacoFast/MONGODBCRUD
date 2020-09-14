using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Alumno
    {
        
        [BsonId]
        public Guid Id { get; set; }
        private int numberControl; 
        private string name;
        private string surname;
        private string secondSurname;
        private string unit;  
        public Carrera carrera { get; set; }
        public Genero gender { get; set; }

     

        public Alumno(int numberControl, string name, string surname, string secondSurname, string unit, Carrera carrera, Genero gender)
        {
            this.numberControl = numberControl;
            this.name = name;
            this.surname = surname;
            this.secondSurname = secondSurname;
            this.unit = unit;
            this.carrera = carrera;
            this.gender = gender;
        }

        public int _numberControl
        {
            get { return numberControl; }
            set { this.numberControl = value; }

        }

        public string _name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string _surname
        {
            get { return surname; }
            set { this.surname = value; }
        }

        public string _secondSurName
        {
            get { return secondSurname; }
            set { this.secondSurname = value; }
        }

        public string _school
        {
            get { return unit; }
            set { this.unit = value; }
        }

      
    }
}
