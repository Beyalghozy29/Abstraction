using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.Interface
{
    public class Sekretaris : IOrganisasiCoperation
    {
        public void StrukturJabatan()
        {
            Console.WriteLine("Sekretaris adalah sebuah profesi administratif yang bersifat asisten/mendukung.");
            Console.WriteLine("Orang yang menjadi ajudan atau pembantu setiap kegiatan yang di lakukan Ketua .");
        }
    }
}