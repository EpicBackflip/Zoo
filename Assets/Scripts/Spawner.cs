using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private List<Animal> animals = new List<Animal>(7);

        private List<Animal> animalobjects = new List<Animal>();
        public InputField InputField;
        
        private void Start()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animalobjects.Add( Instantiate(animals[i], transform));
            }
        }

        public void EatMeat()
        {
            foreach (Animal animal in animalobjects)
            {
                Debug.Log("hi");
                animal.EatMeat();
            }
        }
        public void EatLeaves()
        {
            foreach (Animal animal in animalobjects)
            {
                animal.EatLeaves();
            }
        }

        public void DoTrick()
        {
            foreach (Animal animal in animalobjects)
            {
                animal.StartCoroutine(animal.DoTrick());
            }
        }

        public void SayHello()
        {
            if (InputField.text == "")
            {
                foreach (Animal animal in animalobjects)
                {
                    animal.SayHello();
                }
            }
            foreach (Animal animal in animalobjects)
            {
                if (animal.name == InputField.text)
                {
                    animal.SayHello();
                }
            }
        }
    }
}
