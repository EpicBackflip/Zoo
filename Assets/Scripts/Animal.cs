using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        [HideInInspector]
        public AnimalScriptableObject animalData;
        [Tooltip("drag the balloon object from the animal prefab here")]
        [SerializeField]
        private GameObject balloon;
        [Tooltip("drag the text object from the animal prefab here")]
        [SerializeField]
        private Text text;
        private Image image;
        
        private void Start()
        {
            SetupAnimal();
        }

        // here im setting up the animals sprite and name
        private void SetupAnimal()
        {
            image = GetComponent<Image>();
            image.sprite = animalData.sprite;
            balloon.SetActive(false);
            name = animalData.name;
        }
        // these methods simply activate the balloon and set the text to that of the set attributes of the scriptable object
        // theres no need to deactivate the balloons as this is done by a different script
        public void SayHello()
        {
            balloon.SetActive(true);
            text.text = animalData.animalSound;
        }

        public void EatMeat()
        {
            if (animalData.canEatMeat)
            {
                balloon.SetActive(true);
                text.text = animalData.eatingSound;
            }
        }
        
        public void EatLeaves()
        {
            if (animalData.canEatLeaves)
            {
                balloon.SetActive(true);
                text.text = animalData.eatingSound;
            }
        }
        
        // this method rotates the local transform of the object until the end of the frame so it  makes a full 360 spin
        public IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                if (animalData.canDoTrick)
                {
                    transform.localRotation = Quaternion.Euler(i, 0, 0);
                    yield return new WaitForEndOfFrame();
                }
            }
        }

    }
}
