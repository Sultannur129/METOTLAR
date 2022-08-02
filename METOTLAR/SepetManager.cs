using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METOTLAR
{
    internal class SepetManager
    {
        public void Ekle(Product pr)
        {
            Console.WriteLine("Sepete Eklendi." + " " + pr.Name + " " + pr.price + " " + pr.description);
        }
    }
}
