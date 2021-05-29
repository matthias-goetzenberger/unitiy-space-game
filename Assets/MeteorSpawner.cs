using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;

    public void LevelStart()
    {
        float repeatRate = 1 / Level.Instance.meteorsPerSecond;
        InvokeRepeating("SpawnMeteor", 0, repeatRate);
    }

    void SpawnMeteor()
    {
        float randomX = Random.Range(-8.5f, 8.5f);
        float randomScale = Random.Range(1.0f, 1.5f);
        GameObject meteor = Instantiate(meteorPrefab);
        meteor.transform.position = new Vector3(randomX, transform.position.y, transform.position.z);
        meteor.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
    }
}
