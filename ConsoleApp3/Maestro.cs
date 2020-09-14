﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Maestro
    {
        [BsonId]
        private Guid id;
        private string name;
        private string surname;
        private string secondSurname;

        public Maestro(string name, string surname, string secondSurname)
        {
            this.name = name;
            this.surname = surname;
            this.secondSurname = secondSurname;
        }

        public Guid Id { get => id;}
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string SecondSurname { get => secondSurname; set => secondSurname = value; }


    }
}
