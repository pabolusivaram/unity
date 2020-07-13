using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject powerUp;
    private float spawnRange = 9;
    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(powerUp, GenerateSpawnPosition(), powerUp.transform.rotation);
        SpawnEnemyWave(waveNumber);
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i=0; i<enemiesToSpawn;i++)
        {
            Instantiate(enemy, GenerateSpawnPosition(), enemy.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount==0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerUp, GenerateSpawnPosition(), powerUp.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosz = Random.Range(-spawnRange, spawnRange);

        Vector3 spawnLoc = new Vector3(spawnPosX, 0, spawnPosz);
        return spawnLoc;
    }
}
