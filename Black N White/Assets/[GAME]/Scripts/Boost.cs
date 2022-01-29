using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public GameObject particle;
    public PlayerStats playerStats;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        Instantiate(particle, transform.position, transform.rotation);

        if (playerStats.boostAmount + playerStats.boostIncreaseAmount < PlayerStats.MaxBoostAmount)
        {
            playerStats.boostAmount += playerStats.boostIncreaseAmount;    
        }
        else
        {
            playerStats.boostAmount = PlayerStats.MaxBoostAmount;
        }

        Destroy(gameObject);
    }
}
