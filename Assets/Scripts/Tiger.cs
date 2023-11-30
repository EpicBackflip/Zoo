using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Tiger : Carnivores
    {
        public Tiger()
        {
            name = "wally";
            animalSound = "rraaarww";
            eatingSound = "nomnomnom thx wubalubadubdub";
            canDoTrick = true;
        }
    }
}
