using System;
using System.Collections.Generic;
using System.Text;

namespace projetAssurance
{
    public class Etudiant
    {
        private string nom;
        private string prenom;

        public string Nom { get=>this.nom; 
            set=> this.nom=value.ToUpper(); }
        public string Prenom
        {
            get => this.prenom;
            set => this.prenom = value.ToLower();
        }

        public Etudiant(string nom ,string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public override string ToString()
        {
            return "Nom="+this.Nom +"\n"+ "prenom=" + this.Prenom + "\n";
        }
    }
}
