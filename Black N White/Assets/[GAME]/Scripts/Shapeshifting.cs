using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapeshifting : MonoBehaviour
{
    private bool alreadyPressed;
    public PlayerStats playerStats;
    public GameObject player;
    void Update()
    {

        if (Input.GetKey("space"))
        {
            if (!alreadyPressed)
            { //Buraya boost kısmı eklenecek.
                if (playerStats.color == PlayerStats.colorState.white)
                {
                    player.GetComponent<MeshRenderer>().material = playerStats.blackMaterial;
                    playerStats.color = PlayerStats.colorState.black;
                }
                if (playerStats.color == PlayerStats.colorState.black)
                {
                    player.GetComponent<MeshRenderer>().material = playerStats.whiteMaterial;
                    playerStats.color = PlayerStats.colorState.white;
                }
            }
            
            alreadyPressed = true;
        }

        if (Input.GetKeyUp("space"))
        {
            alreadyPressed = false;
            if (playerStats.color == PlayerStats.colorState.white)
            {
                player.GetComponent<MeshRenderer>().material = playerStats.blackMaterial;
                playerStats.color = PlayerStats.colorState.black;
            }
            else if (playerStats.color == PlayerStats.colorState.white)
            {
                player.GetComponent<MeshRenderer>().material = playerStats.whiteMaterial;
                playerStats.color = PlayerStats.colorState.black;
            }
        }
    }
}
