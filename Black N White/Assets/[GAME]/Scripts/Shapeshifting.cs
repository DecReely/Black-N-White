using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapeshifting : MonoBehaviour
{
    public bool pressed;
    public bool released;
    public PlayerStats playerStats;
    public GameObject player;
    public bool inCheckpoint;

    void Update()
    {

        if (Input.GetKey("space") && playerStats.boostAmount > 0 && !inCheckpoint)
        {
            if (!pressed)
            {
                if (playerStats.color == PlayerStats.colorState.white)
                {
                    player.GetComponent<MeshRenderer>().material = playerStats.blackMaterial;
                    playerStats.color = PlayerStats.colorState.black;
                }
                else if(playerStats.color == PlayerStats.colorState.black)
                {
                    player.GetComponent<MeshRenderer>().material = playerStats.whiteMaterial;
                    playerStats.color = PlayerStats.colorState.white;
                }
                
                pressed = true;
            }
            
            pressed = true;
            released = false;
            
            playerStats.boostAmount -= Time.deltaTime * 10;
            
            if(playerStats.boostAmount <= 0)
            {
                Release();
            }

        }
        
        else if (Input.GetKey("space") && playerStats.boostAmount > 0 && inCheckpoint)
        {
            player.GetComponent<MeshRenderer>().material = playerStats.blackMaterial;
            playerStats.color = PlayerStats.colorState.black;
        }

        if (Input.GetKeyUp("space") && pressed && !inCheckpoint)
        {
            Release();
        }

        
    }
    
    void Release()
    {
        if (!released && !inCheckpoint)
        {
            if (playerStats.color == PlayerStats.colorState.white)
            {
                player.GetComponent<MeshRenderer>().material = playerStats.blackMaterial;
                playerStats.color = PlayerStats.colorState.black;
            }
            else if(playerStats.color == PlayerStats.colorState.black)
            {
                player.GetComponent<MeshRenderer>().material = playerStats.whiteMaterial;
                playerStats.color = PlayerStats.colorState.white;
            }
        }
        pressed = false;
        released = true;
    }
}
