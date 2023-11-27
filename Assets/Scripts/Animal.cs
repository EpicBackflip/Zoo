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
        [HideInInspector]
        public GameObject text;
        public string animalSound;
        public string eatingSound;
        public Animal()
        {

        }
        public void SayHello()
        {
            Balloon.SetActive(true);
            text.GetComponent<Text>().text = animalSound;
        }
        
        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
