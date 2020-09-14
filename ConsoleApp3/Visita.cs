using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Visita
    {
        [BsonId]
        private Guid id;
        private Object user;
        private DateTime date;
        private long universalSeconds;

        public Visita(Object user)
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

        public Guid Id { get => id; }
        public DateTime Date { get => date; set => date = value; }
        public  Object User { get => user; set => user = value; }

        public long UnixSeconds { get => this.universalSeconds; set => this.universalSeconds = value; }

    }
}
