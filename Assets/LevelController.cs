using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject meteorSpawnerPrefab;
    Level level;
    System.DateTime startTime;
    GameObject meteorSpawner;

    // Start is called before the first frame update
    void Start()
    {
        this.level = Level.Instance;
        this.level.Start();
        this.startTime = System.DateTime.UtcNow;
        this.meteorSpawner = Instantiate(meteorSpawnerPrefab);
        this.meteorSpawner.SendMessage("LevelStart");
    }

    // Update is called once per frame
    void Update()
    {
        System.TimeSpan ts = System.DateTime.UtcNow - startTime;
        if (ts.Seconds >= 10)
        {
            this.startTime = System.DateTime.UtcNow;
            this.level.Next();
            this.meteorSpawner.SendMessage("LevelStart");
        }
    }
}
