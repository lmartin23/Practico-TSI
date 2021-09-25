using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContenidoBlazor.Models
{
    public class Contenido
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Descripcion { get; set; }

        public string Categoria { get; set; }

        public string TipoContendio { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }
    }
}
