using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        [Header("required components")]
        [Tooltip("drag the balloon child object from the chosen animal here")]
        [SerializeField]
        private GameObject Balloon;
        [Tooltip("drag the text child object from the chosen animal here")]
        [SerializeField]
        private Text text;
        
        [Header("animal attributes")]
        [Tooltip("here you can set the name animal sound and eating sound for each animal to be displayed based on it's method")]
        public string name;
        [SerializeField]
        private string animalSound;
        [SerializeField]
        private string eatingSound;
        
        [Header("animal booleans")]
        [Tooltip("here you can tick the boxes of the methods you want the animal to be able to execute")]
        [SerializeField]
        private bool canEatMeat;
        [SerializeField]
        private bool canEatLeaves;
        [SerializeField]
        private bool canDoTrick;

        // these methods simply activate the balloon and set the text to that of the set attributes
        // theres no need to deactivate the balloons as this is done by a different script
        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = animalSound;
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
        
        // this method rotates the local transform of the object until the end of the frame so it  makes a full 360 spin
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

    }
}
