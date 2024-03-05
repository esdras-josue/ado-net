using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disk
    {
        public string Title { get; set; }
        public DateTime ReleaseDate {get; set;}
        public int SongsNumber { get; set; }
        public string UrlImagen { get; set; }
        public Edition EditionType { get; set; }
        public MusicalGenre Genre { get; set; }

    }
}
