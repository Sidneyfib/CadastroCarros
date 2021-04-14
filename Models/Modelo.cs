using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudCarro.Models
{
    public class Modelo
    {   [Key]
        public int ModeloId { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        [ForeignKey("Marca")]
        public int MarcaId { get; set; }

        public virtual Marca Marca { get; set; }
    }
}