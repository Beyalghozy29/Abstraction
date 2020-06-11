using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.Interface
{
    public class KetuaLeader : IOrganisasiCoperation
    {
        public void StrukturJabatan()
        {
            Console.WriteLine("Ketua adalah orang yang memimpin jalanya sebuah organisasi.");
            Console.WriteLine("Orang yang tugasnya mengatur baik itu jalanya organisasi dan bertanggung jawab atas semua anggota.");
        }
    }
}
