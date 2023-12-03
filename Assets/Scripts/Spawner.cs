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
        private GameObject animalPrefab;
        private List<GameObject> animalObjects = new List<GameObject>();
        private Vector3 newPosition = new Vector3(512, 384, 0);
        [Tooltip("drag the input field of the scene here")]
        public InputField InputField;
        
        //here I'm spawning 7 of the empty animal prefabs and then looping through them in order to inject the data of the scriptable object into them and setting their position.
        private void Start()
        {
            for (int i = 0; i < animalScriptableObjects.Count; i++)
            {
                animalObjects.Add(Instantiate(animalPrefab,transform));
                animalObjects[i].GetComponent<Animal>().animalData = animalScriptableObjects[i];
                animalObjects[i].transform.position = newPosition;
            }
        }
        // these 3 functions all essentially function the same for all the animals in the list they call the eat method or the dotrick method
        public void EatMeat()
        {
            foreach (GameObject animal in animalObjects)
            {
                animal.GetComponent<Animal>().EatMeat();
            }
        }
        public void EatLeaves()
        {
            foreach (GameObject animal in animalObjects)
            {
                animal.GetComponent<Animal>().EatLeaves();
            }
        }
        // the only difference here is that it uses a startcoroutine as dotrick is a coroutine
        public void DoTrick()
        {
            foreach (GameObject animal in animalObjects)
            {
                StartCoroutine(animal.GetComponent<Animal>().DoTrick());
            }
        }
        // here I check if inputfield is empty in order for all animals to say hello
        public void SayHello()
        {
            if (InputField.text == "")
            {
                foreach (GameObject animal in animalObjects)
                {
                    animal.GetComponent<Animal>().SayHello();
                }
            }
            
            foreach (GameObject animal in animalObjects)
            {
                if (animal.name == InputField.text)
                {
                    animal.GetComponent<Animal>().SayHello();
                }
            }
        }
    }
}
