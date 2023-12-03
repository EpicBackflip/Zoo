using UnityEngine;

[CreateAssetMenu(fileName = "AnimalScriptableObject", menuName = "Animal")]
public class AnimalScriptableObject : ScriptableObject
{

    // scriptableobject that serves as a data holder for each animal.
    // this allows for easier addition of multiple animals of the same type as you don't have to retype everything each time in the inspector.
    [Header("animal attributes")]
    [Tooltip("here you can set the name animal sound and eating sound for each animal to be displayed based on it's method")]
    public string name;
    [SerializeField]
    public string animalSound;
    [SerializeField]
    public string eatingSound;
    [SerializeField]
    public Sprite sprite;
        
    [Header("animal booleans")]
    [Tooltip("here you can tick the boxes of the methods you want the animal to be able to execute")]
    [SerializeField]
    public bool canEatMeat;
    [SerializeField]
    public bool canEatLeaves;
    [SerializeField]
    public bool canDoTrick;
}
