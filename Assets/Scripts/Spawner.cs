using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private List<Animal> animals = new List<Animal>(5);

        private List<Animal> animalobjects = new List<Animal>();
        private void Start()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animalobjects.Add( Instantiate(animals[i], transform));
            }
        }

        public void Eat()
        {
            foreach (Animal animal in animalobjects)
            {
                animal.StartCoroutine(animal.Eat());
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
            foreach (Animal animal in animalobjects)
            {
                animal.StartCoroutine(animal.SayHello());
            }
        }
    }
}
