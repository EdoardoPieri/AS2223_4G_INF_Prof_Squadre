using System.ComponentModel.DataAnnotations;

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
            this.surname = surname;
            this.role = role;
        }

        public string Description()
        {
            return $"{name} {surname} {role}";
        }

        public ERole Role {
            get { return role; }
        }

    }
}