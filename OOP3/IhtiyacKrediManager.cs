using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class IhtiyacKrediManager : IKrediManager   // AMPULE TIKLA IMPLEMENT INTERFACE DİYORUZ 
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İHTİYAÇ KREDİSİ ÖDEME PLANI HESAPLANDI ");
        }
    }
}
