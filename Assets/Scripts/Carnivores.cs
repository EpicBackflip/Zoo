using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Zoo
{ 
    public class Carnivores : Animal
    {
        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.GetComponent<Text>().text = eatingSound;
        }
    }   
}

