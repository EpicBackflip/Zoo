using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : Animal
    {
        public string eatingMeatSound;
        public Pig()
        {
            name = "dora";
            animalSound = "splash";
            eatingSound = "munch munch lovely";
            eatingMeatSound = "nomnomnom oink thx";
        }
    }
}
