// Criação da minha classe de heróis
namespace RpgHero{
    public class Hero{
        public string Name { get; set; }
        private int age;
        public Hero (string name, int age){
            Name = name;
            this.age = age;
        }

        public int Age (){
            return age;
        }
    }
}