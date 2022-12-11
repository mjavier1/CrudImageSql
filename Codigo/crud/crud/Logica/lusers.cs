using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Logica
{
     class lusers
    {
        private int idusuario;
        private string users;
        private string pass;
        private byte [] icono;
        private string  estado;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        public string Users
        {
            get { return users; }
            set { users = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }

        }
        public byte[] Icono
        {
            get { return icono; }
            set
            {
                icono = value;
            }
            
        }
        public string Estado
        {
            get { return estado; }
            set
            {
                estado = value;
            }
         
        }
        public lusers()
        {

        }
        
        public lusers (int idusuario, string users, string pass,byte []icono, string estado)
        {
            Idusuario = idusuario;
            Users = users;
            Pass = pass;
            Icono = icono;
            Estado = estado;

    }
    }
}
