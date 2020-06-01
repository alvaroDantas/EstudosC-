using System;
using System.Collections.Generic;
using System.Text;

namespace efcoremysql.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Observações { get; set; }
        public string Email { get; set; }
        public virtual List<Musica>  Musicas { get; set; }
    }
}
