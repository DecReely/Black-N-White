using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCheckpoint : MonoBehaviour
{
    public Shapeshifting shapeshifting;
    public GameObject player;
    public PlayerStats playerStats;

    private void OnTriggerEnter(Collider other)
    {
        shapeshifting.inCheckpoint = true;
        player.GetComponent<MeshRenderer>().material = playerStats.blackMaterial;
        playerStats.color = PlayerStats.colorState.black;
    }

    private void OnTriggerExit(Collider other)
    {
        shapeshifting.inCheckpoint = false;
        shapeshifting.pressed = false;
        shapeshifting.released = true;

    }
}
