using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Library
{
    public class Player
    {
        string name;
        string surname;
        ERole role;

        public enum ERole 
        { 
            Rosa,
            Riserva
        }
        public Player(string name, string surname, ERole role)
        {
            this.name = name;   
            this.name += " " + surname; 
            this.role = role;
        }

        public string Description()
        {
            return { name surname} ;
        }

        public ERole Role {
            get { return role; }
        }

    }
}