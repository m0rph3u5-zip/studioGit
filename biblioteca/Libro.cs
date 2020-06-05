using System;

namespace biblioteca
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public Utente Utente { get; set; }

        public string Descrizione {
            get {
                return this.Titolo+" di "+this.Autore;
            }
        }

        public void Prestito(Utente utente){
            if (this.Utente != null){
                Console.WriteLine($"Libro già prestato ad altro utente: {this.Utente.Denominazione}");
                return;
            } else {
                this.Utente = utente;
                Console.WriteLine($"Libro prestato a: {this.Utente.Denominazione}");
            }
        }

        public void Restituzione(){
            Console.WriteLine($"L'utente: {this.Utente.Denominazione}, ha restituito il libro, {this.Descrizione}");
            this.Utente = null;
        }
    }
}