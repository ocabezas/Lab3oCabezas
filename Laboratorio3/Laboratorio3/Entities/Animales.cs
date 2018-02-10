using System;
using System.Collections.Generic;
using System.Text;


namespace Laboratorio3.Entities
{
    class Animales : Animal
    {

        public int iD { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public int age { get; set; }
        public DateTime dayOfBirth { get; set; }
        public string favoriteFood { get; set; }
    }

}
