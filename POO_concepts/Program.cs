using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_concepts
{
    public class ModificateurPublic
    {
        // Cette propriété peut être accédé seul dans ce projet 'POO_concepts'.
        internal int ProprieteA = 0;

        public int ProprieteB = 0;
        private int ProprieteC = 0;
        protected int ProprieteD = 0;

    }

    public class AccedeProprieteInternal
    {
        public void essais()
        {
            ModificateurPublic mod = new ModificateurPublic();
            Console.WriteLine("Oui: "+mod.ProprieteA);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ModificateurPublic mod = new ModificateurPublic();
            Console.WriteLine("Essais: " + mod.ProprieteA);
        }
    }
}
