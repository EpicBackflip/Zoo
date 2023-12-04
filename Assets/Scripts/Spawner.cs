using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [Tooltip("Place the scriptable object of the animal you want to be spawned here")]
        [SerializeField]
        private List<AnimalScriptableObject> animalScriptableObjects = new List<AnimalScriptableObject>(7);
        [Tooltip("Place the animal prefab here")]
        [SerializeField] 
        private Animal animalPrefab;
        private List<Animal> animalObjects = new List<Animal>();
        private Vector3 newPosition = new Vector3(512, 384, 0);
        [Tooltip("drag the input field of the scene here")]
        public InputField InputField;
        
        //here I'm spawning 7 of the empty animal prefabs and then looping through them in order to inject the data of the scriptable object into them and setting their position.
        private void Start()
        {
            for (int i = 0; i < animalScriptableObjects.Count; i++)
            {
                animalObjects.Add(Instantiate(animalPrefab,transform));
                animalObjects[i].animalData = animalScriptableObjects[i];
                animalObjects[i].transform.position = newPosition;
            }
        }
        // these 3 functions all essentially function the same, for all the animals in the list they call the eat method based on whether or not they're carnivores or not
        // or the dotrick method
        public void EatMeat()
        {
            foreach (Animal animal in animalObjects)
            {
                if (animal.animalData.canEatMeat)
                {
                    animal.Eat();
                }
            }
        }
        public void EatLeaves()
        {
            foreach (Animal animal in animalObjects)
            {
                if (animal.animalData.canEatLeaves)
                {
                    animal.Eat();
                }
            }
        }
        
        // the only difference here is that it uses a startcoroutine as dotrick is a coroutine
        public void DoTrick()
        {
            foreach (Animal animal in animalObjects)
            {
                StartCoroutine(animal.DoTrick());
            }
        }
        // here I check if inputfield is empty in order for all animals to say hello
        public void SayHello()
        {
            if (InputField.text == "")
            {
                foreach (Animal animal in animalObjects)
                {
                    animal.SayHello();
                }
            }
            
            foreach (Animal animal in animalObjects)
            {
                if (animal.name == InputField.text)
                {
                    animal.SayHello();
                }
            }
        }
    }
}
