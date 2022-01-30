using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteCheckpoint : MonoBehaviour
{
    public Shapeshifting shapeshifting;
    public GameObject player;
    public PlayerStats playerStats;

    private void OnTriggerEnter(Collider other)
    {
        shapeshifting.inCheckpoint = true;
        player.GetComponent<MeshRenderer>().material = playerStats.whiteMaterial;
        playerStats.color = PlayerStats.colorState.white;
    }

    private void OnTriggerExit(Collider other)
    {
        shapeshifting.inCheckpoint = false;
        shapeshifting.pressed = false;
        shapeshifting.released = true;

    }
}
