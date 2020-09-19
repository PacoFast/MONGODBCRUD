using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    [BsonDiscriminator("Visita")]
     class Visita
    {
        public ObjectId id { get; set; }
        public Usuario user { get; set; }
        public DateTime date { get; set; }
        public long universalSeconds { get; set; }
   
        public Visita(Usuario user)
        {

            this.user = user;
            date = DateTime.UtcNow;
            universalSeconds = getUniversalSeconds();
            
        }

        public long getUniversalSeconds()
        {
            var seconds = ((DateTimeOffset)date).ToUnixTimeSeconds();
            return seconds;
        }

       
    }
}
