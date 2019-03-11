using JDRBusiness.Models;
using JDRBusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            B_PJService b_PJService = new B_PJService();

            B_PJ b_PJ = new B_PJ();
            b_PJ = b_PJService.Get(1);
            b_PJ.Details = b_PJService.GetAll(1).ToList();

            

            Console.WriteLine("{0}{1}", b_PJ.Nom, b_PJ.Sexe);

            foreach (B_PJDetails item in b_PJ.Details)
            {
                Console.WriteLine("{0}{1}",item.Nom, item.Valeur);
            }
            Console.ReadLine();

            //test
        }
    }
}
