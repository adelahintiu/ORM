using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColectieMuzeeApp.Models;
using ColectieMuzeeApp.ColectieContext;

namespace ColectieMuzeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ColectieContext.ColectieContext())
            {

                //Inserez un nou muzeu in baza de date
                var muzeu = context.Muzeu;
                var muzeeList = muzeu.ToList();
                var newMuzeu = new Muzeu
                {
                    Denumire = "Muzeul Taranului Roman",
                    NumarStele = 5,
                    BilantViziteId = 1,
                    LocalitateId = 4
                };
                context.Muzeu.Add(newMuzeu);
                context.SaveChanges();

                var newMuzeeList = new List<Muzeu>();
                newMuzeeList.Add(newMuzeu);
                context.Muzeu.AddRange(newMuzeeList);
                context.SaveChanges();


                //Sterg un profil general
                var altProfil = context.ProfilGeneral.FirstOrDefault(x => x.Id == 1);
               
                if (altProfil != null)
                {
                    context.ProfilGeneral.Remove(altProfil);
                }
                
                var profilesToDeleteList = context.ProfilGeneral.Where(x => x.Id > 1).ToList();
                context.ProfilGeneral.RemoveRange(profilesToDeleteList);
                context.SaveChanges();



                Console.ReadKey();
            }
        }
    }
}
