using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;
using AbstractClass.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //UNTUK ABSTRACT
            /*OrganisasiCoperation organisasicoperation;//objek polymorphism

            organisasicoperation = new KetuaLeader();
            organisasicoperation.StrukturJabatan();

            Console.WriteLine();
            organisasicoperation = new Sekretaris();
            organisasicoperation.StrukturJabatan();

            Console.WriteLine();
            organisasicoperation = new Member_Anggota();
            organisasicoperation.StrukturJabatan();*/

            //UNTUK INTERFACE

            IOrganisasiCoperation organisasicoperation;

            organisasicoperation = new KetuaLeader();
            organisasicoperation.StrukturJabatan();

            Console.WriteLine();
            organisasicoperation = new Sekretaris();
            organisasicoperation.StrukturJabatan();

            Console.WriteLine();
            organisasicoperation = new Member_Anggota();
            organisasicoperation.StrukturJabatan();
            Console.ReadKey();
        }
    }
}