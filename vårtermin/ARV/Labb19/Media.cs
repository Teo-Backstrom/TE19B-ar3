using System;

namespace Labb19
{
    public class Media
    {
        public string Titel { get; set; }

        public virtual string TillText()
        {
            return null;
        }
    }
}