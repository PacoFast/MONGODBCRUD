using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Genero
    {
       

        private string gender;

        public Genero(string gender)
        {
            this.gender = gender;
        }

        public string Gender { get => gender; set => gender = value; }



    }
}
