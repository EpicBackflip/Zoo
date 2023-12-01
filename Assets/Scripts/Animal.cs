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
        [SerializeField]
        private string animalSound;
        [SerializeField]
        private string eatingSound;
        [SerializeField]
        private bool canEatMeat;
        [SerializeField]
        private bool canEatLeaves;
        [SerializeField]
        private bool canDoTrick;
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
            if (canEatMeat)
            {
                Balloon.SetActive(true);
                text.text = eatingSound;
            }
        }
        
        public void EatLeaves()
        {
            if (canEatLeaves)
            {
                Balloon.SetActive(true);
                text.text = eatingSound;
            }
        }
    }
}
