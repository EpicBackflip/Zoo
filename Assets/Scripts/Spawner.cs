using UnityEngine;
using UnityEngine.Events;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {

        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra;
        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            henk.Balloon = henk.transform.GetChild(0).gameObject;
            Debug.Log(henk.Balloon.name);
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.Balloon = elsa.transform.GetChild(0).gameObject;
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.Balloon = dora.transform.GetChild(0).gameObject;
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.Balloon = wally.transform.GetChild(0).gameObject;
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.Balloon = marty.transform.GetChild(0).gameObject;
        }
    }
}
