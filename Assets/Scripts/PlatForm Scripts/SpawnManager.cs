using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    private float starSpawner = 0.01f;
    private float intervalSpawner = 4f;
    private float max = 2;
    public bool gameplay = true;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomPlatform), starSpawner, intervalSpawner);
    }

    // Update is called once per frame
    private void Update()
    {
        /*if (gameplay == true)
        {
            SpawnRandomPlatform();
        }*/

        //  SpawnRandomPlatform();
    }

    private void SpawnRandomPlatform()
    {
        Debug.Log("SpwamRandom Call");
        int platformIndex = Random.Range(0, platformPrefabs.Length - 1);
        Debug.Log("PlatformIndex Set " + platformIndex);
        Vector3 pos = new Vector3(Random.Range(-max, max), -6, 10);
        Debug.Log("Vector pos Set " + pos);

        Instantiate(platformPrefabs[platformIndex], pos, Quaternion.identity);// platformPrefabs[platformIndex].transform.rotation);
        Debug.Log("PlatformCalling....." + platformPrefabs.ToString());
    }
}
