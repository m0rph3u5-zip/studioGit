using System;
using System.Collections.Generic;
using System.Linq;

namespace biblioteca
{
    public class Program
    {          
        static void Main(string[] args)
        {
            Utente Utente1 = new Utente(){
                Id = 1,
                Nome = "Mario",
                Cognome = "Rossi",
                AnnoIscrizione = 2015
            };

            Console.WriteLine("Utente aggiunto "+Utente1.Denominazione);

            Utente Utente2 = new Utente(){
                Id = 2,
                Nome = "Luigi",
                Cognome = "Rinaldi",
                AnnoIscrizione = 2020
            };

            Console.WriteLine("Utente aggiunto "+Utente1.Denominazione);

            Libro Libro1 = new Libro() {
                Id = 1,
                Titolo = "Il Piccolo Principe",
                Autore = "Antoine de Saint-Exupéry"
            };

            Libro Libro2 = new Libro() {
                Id = 2,
                Titolo = "Il Piccolo Principe",
                Autore = "Antoine de Saint-Exupéry"
            };

            Libro Libro3 = new Libro() {
                Id = 3,
                Titolo = "Il Piccolo Principe",
                Autore = "Antoine de Saint-Exupéry"
            };

            Libro Libro4 = new Libro() {
                Id = 4,
                Titolo = "Il Piccolo Principe",
                Autore = "Antoine de Saint-Exupéry"
            };
            
            Console.WriteLine("Libro aggiunto ");
            Console.WriteLine(Utente1.Denominazione);
            Libro1.Prestito(Utente1);
            Libro1.Prestito(Utente2);
            Libro1.Restituzione();
            Libro1.Prestito(Utente2);

            List<Libro> biblioteca = new List<Libro>();

            biblioteca.Add(Libro1);
            biblioteca.Add(Libro2);
            biblioteca.Add(Libro3);
            biblioteca.Add(Libro4);

            IEnumerable<Libro> resultQuery = 
                from Libro in biblioteca
                where Libro.Id > 1
                select Libro; 
           
            foreach (Libro libro in resultQuery)
            {
                Console.WriteLine(libro.Id + " ");
            }
        }
    }
}
