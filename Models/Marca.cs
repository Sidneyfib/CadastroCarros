using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudCarro.Models
{
    public class Marca
    {   [Key]
        public int MarcaId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Modelo> Modelos { get; set; }
    }
}