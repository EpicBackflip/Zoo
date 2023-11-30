using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        public string name;
        public GameObject Balloon;
        public Text text;
        protected string animalSound;
        protected string eatingSound;
        protected bool canEatMeat;
        protected bool canEatLeaves;
        protected bool canEatBoth;
        protected bool canDoTrick;
        protected Animal()
        {
            
        }
        
        public Animal(string animalSound, string eatingSound)
        {
            this.animalSound = animalSound;
            this.eatingSound = eatingSound;
        }
        
        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = animalSound;
        }

        public IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                if (canDoTrick)
                {
                    transform.localRotation = Quaternion.Euler(i, 0, 0);
                    yield return new WaitForEndOfFrame();
                }
            }
        }

        public void EatMeat()
        {
            if (canEatMeat || canEatBoth)
            {
                Balloon.SetActive(true);
                text.text = eatingSound;
            }
        }
        
        public void EatLeaves()
        {
            if (canEatLeaves || canEatBoth)
            {
                Balloon.SetActive(true);
                text.text = eatingSound;
            }
        }
    }
}
