using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public EnemyGroup[] enemies;

    /// <summary>
    /// Add a group of enemies to this wave
    /// </summary>
    /// <param name="group"></param>
    public void AddEnemyGroup(EnemyGroup group)
    {
        EnemyGroup[] temp = new EnemyGroup[enemies.Length + 1];
        for(int i = 0; i < enemies.Length; i++)
        {
            temp[i] = enemies[i];
        }
        temp[temp.Length - 1] = group;
        enemies = temp;
    }
    /// <summary>
    /// Create a group of enemies to add to add to this wave
    /// </summary>
    /// <param name="enemy"></param>
    /// <param name="amount"></param>
    public void AddEnemyGroup(Enemy enemy, int amount)
    {
        EnemyGroup newEnemyGroup = new EnemyGroup(enemy, amount);
        AddEnemyGroup(newEnemyGroup);
    }
}
