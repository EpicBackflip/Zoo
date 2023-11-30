using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{

    class Pig : Carnivores
    {
        public Pig()
        {
            canEatBoth = true;
            name = "dora";
            animalSound = "oink oink";
            eatingSound = "munch munch oink";
            canDoTrick = true;
        }
    }
}
