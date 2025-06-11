using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    private float spawnRange = 9.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        Instantiate(EnemyPrefab, GenerateSpawnPosition(),
        EnemyPrefab.transform.rotation);


    Vector3 GenerateSpawnPosition (){
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
