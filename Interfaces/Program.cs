using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // interface
    interface IEtudiant
    {
        void Enregistrer();
        void Inscrire();
    }

    // classe dérivée
    class Etudiant : IEtudiant
    {
        public void Enregistrer()
        {
            throw new NotImplementedException();
        }

        public void Inscrire()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
