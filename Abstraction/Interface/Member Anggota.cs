using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.Interface
{
    public class Member_Anggota : IOrganisasiCoperation
    {
        public void StrukturJabatan()
        {
            Console.WriteLine("Member merupakan sebuah status yang diberikan kepada seseorang atau lembaga dari sebuah perkumpulan atau organisasi.");
            Console.WriteLine("Orang yang menjalankan perintah ketua dalam organisasi .");
        }
    }
}
