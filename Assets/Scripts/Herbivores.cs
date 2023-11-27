using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Herbivores : Animal
    {
        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.GetComponent<Text>().text = "munch munch oink";
        }
    }
}

