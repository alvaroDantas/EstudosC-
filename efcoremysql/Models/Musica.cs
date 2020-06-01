using System;
using System.Collections.Generic;
using System.Text;

namespace efcoremysql.Models
{
    public class Musica
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public virtual Album Album { get; set; }
    }
}
