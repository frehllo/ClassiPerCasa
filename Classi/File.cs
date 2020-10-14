using System;

namespace Classi
{
    public class File
    {
        private string nome, estensione;
        private long dimensione;

        public File(string n, string e, long d)
        {
            nome = n;
            estensione = e;
            dimensione = d;
        }
            
        public void Duplicati()
        {

        }

        public void Copiati()
        {

        }

        public void Eliminati()
        {

        }
    }

    public class Lavoratore
    {
        private string nome, professione;
        private int età;

        public Lavoratore(string n, string p, int e)
        {
            nome = n;
            professione = p;
            età = e;
        }

        public void Svegliati()
        {

        }

        public void Lavora()
        {

        }

        public void Dormi()
        {

        }

        public string Presentati()
        {
            return $"Mi chiamo {nome}, ho {età} anni e sono un/una {professione}";
        }
    }

    public class Gatto
    {
        private string nome, colore, razza;
        private int età;

        public Gatto(string n, string c, string r, int e)
        {
            nome = n;
            colore = c;
            razza = r;
            età = e;
        }

        public void Salta()
        {

        }

        public void Miagola()
        {

        }

        public void Graffia()
        {

        }

    }
}
