namespace Labb19
{
    public class Filmer : Media
    {
        public string Regissör { get; set; }
        public string Spellängd { get; set; }

        public Filmer(string t, string regissör, string spellängd) : base(t)
        {
            Regissör = regissör;
            Spellängd = spellängd;
        }
        public override string TillText()
        {
            return $"Titel: {Titel} Regissör: {Regissör} Spellängd: {Spellängd}";

        }
    }
}