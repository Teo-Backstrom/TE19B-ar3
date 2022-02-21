namespace Labb19
{
    public class Media
    {
        public string Titel { get; set; }

        public Media(string titel)
        {
            Titel = titel;
        }

        public virtual string TillText()
        {
            return null;
        }
    }
}