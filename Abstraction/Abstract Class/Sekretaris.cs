using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class Sekretaris : OrganisasiCoperation
    {
        public override void StrukturJabatan()
        {
            Console.WriteLine("Sekretaris adalah sebuah profesi administratif yang bersifat asisten/mendukung.");
            Console.WriteLine("Orang yang menjadi ajudan atau pembantu setiap kegiatan yang di lakukan Ketua .");
        }
    }
}