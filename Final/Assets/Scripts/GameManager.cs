using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int waveNumber = 1;
    public int enemyCount;
    public float spawnRangeX = 5;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition()
                      , enemyPrefab.transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPosition ()
    {
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 randomPos = new Vector3(spawnPosX, 100, 170);
        return randomPos;
    }
     void update ()
    {
         enemyCount = FindObjectsOfType<Enemy>().Length;
         if (enemyCount == 0) waveNumber++; SpawnEnemyWave(waveNumber);
    }
}