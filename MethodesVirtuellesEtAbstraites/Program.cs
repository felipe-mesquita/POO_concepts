using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodesVirtuellesEtAbstraites
{
    // classe abstrait
    public abstract class Jeu
    {
        // Cette méthode est abstrait, donc il n'y a pas implémentation dans la classe abstrait.
        // Cette méthode doit être implémenté dans la classe dérivée.
        public abstract void Nom();

        // Je peux avoir quelque méthode pas abstrait, et avec propre implémentation.
        public void Type()
        {
            Console.WriteLine("Jeu Video");
        }
    }

    // classe dérivée 
    class Halo : Jeu
    {
        public override void Nom()
        {
            Console.WriteLine("Halo");
        }
    }

    //--------------------------------------------

    public class Personne
    {
        // Cette classe posséde cette méthode 'virtuelle'.
        // Cette méthode doit avoir propre implémentation.
        public virtual string sexe() { return ""; }
    }

    public class Garcon : Personne
    {
        // Cette méthode est la substitution de la méthode virtuelle (de la classe de base).
        // Ce n'est pas obligatoire.
        public override string sexe()
        {
            return "Masculin";
        }
    }

    public class Fille : Personne
    {
        public override string sexe()
        {
            return "Féminin";
        }
    }

    public class Fils : Personne
    {
        public int Age()
        {
            return 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Halo halo = new Halo();
            halo.Type();
            halo.Nom();

            Personne pers = new Personne();
            String sexe0 = pers.sexe();

            Console.WriteLine("Sexe: " + sexe0);

            Personne gars = new Garcon();
            String sexe1 = gars.sexe();

            Console.WriteLine("Sexe: "+ sexe1);

            Personne filles = new Fille();
            String sexe2 = filles.sexe();

            Console.WriteLine("Sexe: " + sexe2);

            Console.ReadLine();
        }
    }
}
