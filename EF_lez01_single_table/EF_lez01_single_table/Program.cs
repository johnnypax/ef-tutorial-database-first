using EF_lez01_single_table.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_lez01_single_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inserimento
            //Contatto mar = new Contatto()
            //{
            //    Nome = "Maria",
            //    Cognome = "Mariucci",
            //    CodFis = "MRAMRC",
            //    Email = "mar@iuc.com",
            //    Eta = 45,
            //};

            //using (EfLez01SingleTableContext ctx = new EfLez01SingleTableContext())
            //{
            //    try
            //    {
            //        ctx.Contattos.Add(mar);
            //        ctx.SaveChanges();

            //        Console.WriteLine("Tutto apposto, salvataggio riuscito");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            #endregion

            #region Ricerca singola
            //using (EfLez01SingleTableContext ctx = new EfLez01SingleTableContext())
            //{
            //    //try
            //    //{
            //    //    Contatto con = ctx.Contattos.Single(c => c.ContattoId == 8);
            //    //    Console.WriteLine(con);
            //    //}
            //    //catch (Exception ex)
            //    //{
            //    //    Console.WriteLine(ex.Message);
            //    //}

            //    Contatto? con = ctx.Contattos.FirstOrDefault(c => c.ContattoId == 80);
            //    if(con is not null)
            //    {
            //        Console.WriteLine(con);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Elemento non trovato!");
            //    }
            //}
            #endregion

            #region Ricerca tutti gli elementi
            //using (EfLez01SingleTableContext ctx = new EfLez01SingleTableContext())
            //{
            //    //List<Contatto> elenco = ctx.Contattos.ToList();
            //    //IList<Contatto> elenco = ctx.Contattos.ToList();
            //    //ICollection<Contatto> elenco = ctx.Contattos.ToList();
            //    IEnumerable<Contatto> elenco = ctx.Contattos.ToList();

            //    foreach (Contatto item in elenco)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Ricerche avanzate
            //using (EfLez01SingleTableContext ctx = new EfLez01SingleTableContext())
            //{
            //    //Ricerca del contatto val@verdi.com come email
            //    //List<Contatto> elenco = ctx.Contattos.Where(c => c.Email == "val@verdi.com").ToList();

            //    //Ricerca tutti coloro che hanno una eta > 60
            //    //List<Contatto> elenco = ctx.Contattos.Where(c => c.Eta > 60).ToList();

            //    //Ricerca tutti coloro che hanno un nome che inizia per "Ma"
            //    //List<Contatto> elenco = ctx.Contattos.Where(c => c.Nome.StartsWith("Ma")).ToList();

            //    //Ricerca tutti coloro che hanno un nome che finisce per "io"
            //    //List<Contatto> elenco = ctx.Contattos.Where(c => c.Nome.EndsWith("io")).ToList();

            //    //Ricerca tutti coloro che hanno all'interno del nome la dicitura "io"
            //    List<Contatto> elenco = ctx.Contattos.Where(c => EF.Functions.Like(c.Nome, "%io%")).ToList();

            //    foreach (Contatto item in elenco)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Eliminazione
            //using (EfLez01SingleTableContext ctx = new EfLez01SingleTableContext())
            //{
            //    Contatto con = new Contatto()
            //    {
            //        ContattoId = 7,
            //    };

            //    try
            //    {
            //        ctx.Entry(con).State = EntityState.Deleted;         //Marco l'oggetto come eliminato
            //        ctx.SaveChanges();

            //        Console.WriteLine("ELiminato con successo");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.ToString());
            //    }
            //}
            #endregion

            using (EfLez01SingleTableContext ctx = new EfLez01SingleTableContext())
            {
                try
                {
                    //Caricamento
                    Contatto? gio = ctx.Contattos.FirstOrDefault(c => c.ContattoId == 5);
                    if (gio is not null)
                    {
                        //Modifica
                        gio.Nome = "Giovannino";
                        gio.Email = "giovannino@pace.com";

                        //Salvataggio
                        ctx.SaveChanges();

                        Console.WriteLine("Tutto ok!");
                    }
                    else
                        Console.WriteLine("Persona non trovata");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
