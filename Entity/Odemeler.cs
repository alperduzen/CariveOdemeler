using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Odemeler
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public double Alacak { get; set; }
        public double Borc { get; set; }
        public DateTime Tarih { get; set; }
        public string BelgeNo { get; set; }
        public DateTime VadeTarihi { get; set; }
    }
}
