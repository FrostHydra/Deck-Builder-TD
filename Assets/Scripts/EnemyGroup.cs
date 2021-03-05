using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGroup : MonoBehaviour
{
    public Enemy enemy;
    public int amount;

    public EnemyGroup(Enemy enemy, int amount)
    {
        this.enemy = enemy;
        this.amount = amount;
    }

    public void UpdateGroup(Enemy enemy, int amount)
    {
        this.enemy = enemy;
        this.amount = amount;
    }

    public void UpdateGroup(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public void UpdateGroup(int amount)
    {
        this.amount = amount;
    }

    public void IncreaseAmount(int increase)
    {
        this.amount += amount;
    }
}
