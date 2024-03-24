using EF_lez02_one_to_many.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_lez02_one_to_many
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inserimento
            //Persona osv = new Persona()  { Nome = "Osvaldo", Cognome = "Osvaldini", Email = "osv@osv.com" };

            //Cartum carUno = new Cartum() { Codice = "KK123", Negozio = "Kernel Store", PersonaRifNavigation = osv };
            //Cartum carDue = new Cartum() { Codice = "PP987", Negozio = "Poly Store", PersonaRifNavigation = osv };

            //using (EfLez02OneToManyContext ctx = new EfLez02OneToManyContext())
            //{
            //    try
            //    {
            //        ctx.Personas.Add(osv);
            //        ctx.Carta.Add(carUno);
            //        ctx.Carta.Add(carDue);

            //        ctx.SaveChanges();

            //        Console.WriteLine("Tutto ok!");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.ToString());
            //    }

            //}
            #endregion

            using (EfLez02OneToManyContext ctx = new EfLez02OneToManyContext())
            {
                #region Ricerca persona
                //try
                //{
                //    Persona gio = ctx.Personas
                //       .Include(per => per.Carta)
                //       .Single(p => p.Email == "gio@pace.com");

                //    Console.WriteLine(gio);

                //    foreach(Cartum car in gio.Carta)
                //    {
                //        Console.WriteLine(car);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.ToString());
                //}
                #endregion

                try
                {
                    Cartum car = ctx.Carta
                        .Include(car => car.PersonaRifNavigation)
                        .Single(c => c.Codice == "KK123");

                    Console.WriteLine(car);

                    Console.WriteLine(car.PersonaRifNavigation);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}
