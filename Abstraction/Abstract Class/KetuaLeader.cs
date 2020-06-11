using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class KetuaLeader : OrganisasiCoperation
    {
        public override void StrukturJabatan()
        {
            Console.WriteLine("Ketua adalah orang yang memimpin jalanya sebuah organisasi.");
            Console.WriteLine("Orang yang tugasnya mengatur baik itu jalanya organisasi dan bertanggung jawab atas semua anggota.");
        }
    }
}