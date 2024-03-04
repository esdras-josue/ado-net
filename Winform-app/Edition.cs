using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_app
{
    internal class Edition
    {
        public int Id {  get; set; }
        public string EditionDescripcion {  get; set; }

        public override string ToString()
        {
            return EditionDescripcion;
        }
    }
}
