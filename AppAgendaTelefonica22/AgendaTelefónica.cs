using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAgendaTelefonica22
{
    public class AgendaTelefónica
    {
        private List<Contacto> contactos;

        public List<Contacto> Contactos
        {
            get { return contactos; }
        }

        public void Agregar(string nombre, string dirección, 
            string teléfono, TiposDeTeléfono tipoDeTeléfono)
        {
            if (contactos==null)
            {
                contactos=new List<Contacto>();
            }
            var nuevo = new Contacto()
            {
                Nombre = nombre,
                Dirección =dirección,
                Teléfono = teléfono,
                TipoDeTeléfono = tipoDeTeléfono
            };
            contactos.Add(nuevo);
        }
    }
}
