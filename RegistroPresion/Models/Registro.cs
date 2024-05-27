using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPresion.Models
{
    [Table("registropresiones")]
    public class Registro
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public byte Diastolica { get; set; }
        [NotNull]
        public byte Sistolica { get; set; }
        [NotNull]
        public byte Pulso { get; set; }
        [NotNull]
        public DateTime Fecha { get; set; }

        [Ignore]
        public string? Categoria { get; set; }
    }
}
