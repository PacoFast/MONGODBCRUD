using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Usuario
    {
        private Guid id;
        private Object userType;
        private byte[] bitmap;

        public Usuario(object userType, byte[] bitmap)
        {
            this.userType = userType;
            this.bitmap = bitmap;
        }

        public Usuario(Object userType)
        {
            this.userType = userType;
        }

        public Guid Id { get => id; }
        public object UserType { get => userType; set => userType = value; }
        public byte[] Bitmap { get => bitmap; set => bitmap = value; }
    }
}
