using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        //list for refferences of the animals to instantiate 
        [SerializeField]
        [Tooltip("place a prefab of an animal here to have it spawned when the game starts")]
        private List<Animal> animals = new List<Animal>(7);
        // list of actual animal objects in the game
        private List<Animal> animalobjects = new List<Animal>();
        public InputField InputField;
        
        //here I instantiate the animals that i've manually put in the list in the inspector
        private void Start()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animalobjects.Add( Instantiate(animals[i], transform));
            }
        }
        // these 3 functions all essentially function the same for all the animals in the list they call the eat method or 
        // the dotrick method
        public void EatMeat()
        {
            foreach (Animal animal in animalobjects)
            {
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
        // the only difference here is that it uses a startcoroutine as totrick is a coroutine
        public void DoTrick()
        {
            foreach (Animal animal in animalobjects)
            {
                animal.StartCoroutine(animal.DoTrick());
            }
        }
        // here I check if inputfield is empty in order for all animals to say hello
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
                // here i check if the inputfield text corresponds to an animal name if so that animal says hello
                if (animal.name == InputField.text)
                {
                    animal.SayHello();
                }
            }
        }
    }
}
