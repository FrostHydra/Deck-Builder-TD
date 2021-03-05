using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Trait))]
[RequireComponent(typeof(EnemyMovement))]
public class Enemy : MonoBehaviour
{
    public int health;
    public float speed = 1;
    public WaveManager waveManager;
    int maxHealth;
    EnemyMovement movement;

    private void Awake()
    {
        maxHealth = health;
        movement = this.gameObject.GetComponent<EnemyMovement>();
    }

    public void SetWaveManager(WaveManager waveManager)
    {
        this.waveManager = waveManager;
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public void ApplyMultipliers(float healthMultiplier, float speedMultiplier)
    {
        float temp = health;
        temp *= healthMultiplier;
        health = (int)temp;
        speed *= speedMultiplier;
    }

    /// <summary>
    /// Positive value for damage
    /// Negative value for healing
    /// </summary>
    /// <param name="damage"></param>
    public void UpdateHealth(int damage)
    {
        health -= damage;

        if (health < 0)
        {
            Death();
        }

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    public int GetHealth()
    {
        return health;
    }

    public void Death()
    {
        Destroy(this.gameObject);
    }

    public void SetWaypoint(Waypoint waypoint)
    {
        movement.SetWaypoint(waypoint);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Waypoint>())
        {
            Waypoint temp = collision.gameObject.GetComponent<Waypoint>();
            SetWaypoint(temp.GetNextCheckpoint());
            if (temp.isEnd())
            {
                Destroy(this.gameObject);
                Debug.Log("Life lost");
            }
        }
    }
}
