using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public Wave[] waves;
    [Min(1.0f)] public float enemySpeedMultiplier;
    [Min(1.0f)] public float enemyCountMultiplier;
    [Min(1.0f)] public float enemyHealthMultiplier;
    [Min(0.2f)] public float spawnInterval;
    public Waypoint firstWaypoint;

    /*
    private void Start()
    {
        SpawnWave(1);
    }
    */

    /// <summary>
    /// Waves start at 1
    /// </summary>
    /// <param name="waveNumber"></param>
    public void SpawnWave(int waveNumber)
    {
        StartCoroutine(SpawnDelay(waveNumber, spawnInterval));
    }

    public void SpawnEnemy(Enemy enemy)
    {
        Enemy newEnemy = GameObject.Instantiate(enemy);
        newEnemy.ApplyMultipliers(enemyHealthMultiplier, enemySpeedMultiplier);
        newEnemy.SetWaveManager(this);
        newEnemy.SetWaypoint(firstWaypoint);
        newEnemy.transform.position = firstWaypoint.transform.position;
    }

    IEnumerator SpawnDelay(int waveNumber, float delayTimer)
    {
        int enemyGroups = waves[waveNumber - 1].enemies.Length;
        
        //Select group
        for (int i = 0; i < enemyGroups; i++)
        {
            float newCount = enemyCountMultiplier;
            newCount *= waves[waveNumber - 1].enemies[i].amount;

            //Spawn for each enemy in group
            for (int j = 0; j < (int)newCount; j++)
            {
                yield return new WaitForSeconds(delayTimer);
                SpawnEnemy(waves[waveNumber - 1].enemies[i].enemy);
            }
        }
    }
}
