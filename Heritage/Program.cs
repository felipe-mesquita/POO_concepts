using ClassesStatiques;
using POO_concepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    // classe de base
    public class Animal
    {
        // Cette propriété peut être accédé seul dans la classe 'Animal'.
        private int Age = 10;
       
        // Cette propriété peut être accédé dans la classe 'Animal' et dans la classe qui hérité de la classe 'Animal'.
        protected string Nom() { return "return protected"; }
        
        // Cette propriété peut être accédé dans toutes les classes.
        public string Pronom = "propriété public";

        public void Marcher()
        {
            Console.WriteLine("Accéder une propriété: (private) " + Age);
        }
    }

    // classe dérivée 
    public class Oiseaux : Animal
    {
        protected string A;
        public void Picorer()
        {
            Console.WriteLine("Accéder une propriété: (public) " + Pronom);
            Console.WriteLine("Accéder classe dérivée: (proteced) " + Nom());
            //Console.WriteLine("Accéder classe dérivée: (private) " + Age);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Oiseaux oiseaux = new Oiseaux();
            oiseaux.Picorer();
            oiseaux.Marcher();

            ModificateurPublic mod = new ModificateurPublic();
            Console.WriteLine("Accéder Propriété d'autre projet: (public) " + mod.ProprieteB);
            Console.ReadLine();
        }
    }
}
