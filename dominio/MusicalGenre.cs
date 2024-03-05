using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class MusicalGenre
    {
        public int Id { get; set; }
        public string GenreDescripcion {  get; set; }

        public override string ToString()
        {
            return GenreDescripcion;
        }
    }
}
