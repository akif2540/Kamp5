using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    internal class GercekMusteri:Musteri
    {
        
        public string TcNo { get; set; } // çarpma bölme yoksa ona bir matemematik işlem yapmıyorsan string olarak yapmak daha iyi olur.
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        

    }
}
