namespace biblioteca
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Denominazione { 
            get {
                return this.Cognome+" "+this.Nome;
            }
        }
    }
}