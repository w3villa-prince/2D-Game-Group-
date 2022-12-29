using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    private float starSpawner = 1.5f;
    private float intervalSpawner = 1f;
    private float max = 2;
    public bool gameplay = true;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("SpawnRandomPlatform", starSpawner, intervalSpawner);
    }

    private void SpawnRandomPlatform()
    {
        int platformIndex = Random.Range(0, platformPrefabs.Length - 1);
        Vector3 pos = new Vector3(Random.Range(-max, max), 6, 10);
        Instantiate(platformPrefabs[platformIndex], pos, platformPrefabs[platformIndex].transform.rotation);
    }

    // Update is called once per frame
    private void Update()
    {
        if (gameplay == true)
        {
            SpawnRandomPlatform();
        }
    }
}
