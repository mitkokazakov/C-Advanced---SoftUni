

namespace PokemonTrainer
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Eelement { get; set; }
        public int Health { get; set; }

        public Pokemon(string name, string element,int health)
        {
            this.Name = name;
            this.Eelement = element;
            this.Health = health;
        }

        
        //public override string ToString()
        //{
        //    return $"{this.Name} -- {this.Eelement} -- {this.Health}";
        //}
    }
}
