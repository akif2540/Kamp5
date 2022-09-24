using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{                                          // OKUNURLUĞU ARTIRMAK İÇİN İNTERFACE LER I harfi ile başlar isimlendirilirken
     internal interface IKrediManager     // Burada class yerine interface yaptık ve public i sildik süslü parentezi kaldırdık.
    {                                    // buradaki amaç burada birden fazla işlem yapmak örneğin hem konut kredisi hesaplamak hem ihtiyaç kredisi.
       void Hesapla();
        void BiseyYap();
       
        
    }
}
