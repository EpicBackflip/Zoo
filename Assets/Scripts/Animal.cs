using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        public string name;
        public GameObject Balloon;
        public Text text;
        [HideInInspector]
        public string animalSound;
        [HideInInspector]
        public string eatingSound;
        public Animal()
        {

        }
        public IEnumerator SayHello()
        {
            Balloon.SetActive(true);
            text.text = animalSound;
            yield return new WaitForSeconds(3);
            Balloon.SetActive(false);
        }

        public IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }

        public IEnumerator Eat()
        {
            Balloon.SetActive(true);
            text.text = eatingSound;
            yield return new WaitForSeconds(3);
            Balloon.SetActive(false);
        }
    }
}
