using UnityEngine;

public class Level : MonoBehaviour
{
    // This field can be accesed through our singleton instance,
    // but it can't be set in the inspector, because we use lazy instantiation
    public int meteorSpeed = 1;
    public float meteorsPerSecond = 1;
    public int number = 1;

    // Static singleton instance
    private static Level instance;

    // Static singleton property
    public static Level Instance
    {
        // Here we use the ?? operator, to return 'instance' if 'instance' does not equal null
        // otherwise we assign instance to a new component and return that
        get { 

            if (instance == null)
            {
                instance = new GameObject("Level").AddComponent<Level>();
            }

            return instance;
        }
    }

    public void Start()
    {
        this.meteorSpeed = 1;
        this.meteorsPerSecond = 1;
        this.number = 1;
    }

    public void Next()
    {
        this.meteorSpeed += 1;
        this.meteorsPerSecond += 0.2f;
        this.number += 0;
    }
}
