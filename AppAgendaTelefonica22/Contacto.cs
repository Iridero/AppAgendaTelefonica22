using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAgendaTelefonica22
{
    public enum TiposDeTeléfono { Casa, Celular, Trabajo }
    [Serializable]
    public class Contacto
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string teléfono;

        public string Teléfono
        {
            get { return teléfono; }
            set { teléfono = value; }
        }
        private string dirección;

        public string Dirección
        {
            get { return dirección; }
            set { dirección = value; }
        }

        private TiposDeTeléfono tipoDeTeléfono;

        public TiposDeTeléfono TipoDeTeléfono
        {
            get { return tipoDeTeléfono; }
            set { tipoDeTeléfono = value; }
        }

    }
}
