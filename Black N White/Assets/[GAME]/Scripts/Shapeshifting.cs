using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapeshifting : MonoBehaviour
{
    public bool alreadyPressed;
    public bool released;
    public PlayerStats playerStats;
    public GameObject player;
    void Update()
    {

        if (Input.GetKey("space") && playerStats.boostAmount > 0)
        {
            
            if (!alreadyPressed)
            { //Buraya boost kısmı eklenecek.
                Debug.Log("deneme");
                alreadyPressed = true;
                if (playerStats.color == PlayerStats.colorState.white)
                {
                    player.GetComponent<MeshRenderer>().material = playerStats.blackMaterial;
                    playerStats.color = PlayerStats.colorState.black;
                }
                else if (playerStats.color == PlayerStats.colorState.black)
                {
                    player.GetComponent<MeshRenderer>().material = playerStats.whiteMaterial;
                    playerStats.color = PlayerStats.colorState.white;
                }
                
            }
            
            playerStats.boostAmount -= playerStats.boostDecreaseAmount * Time.deltaTime;
            Debug.Log(playerStats.boostAmount);

            if (playerStats.boostAmount <= 0)
            {
                released = true;
                Release();
            }
                

            alreadyPressed = true;
        }

        if (Input.GetKeyUp("space") && alreadyPressed && !released)
        {
            Release();
            released = false;
        }
        
    }

    void Release()
    {
        //alreadyPressed = false;
        if (playerStats.color == PlayerStats.colorState.white)
        {
            player.GetComponent<MeshRenderer>().material = playerStats.blackMaterial;
            playerStats.color = PlayerStats.colorState.black;
        }
        else if (playerStats.color == PlayerStats.colorState.black)
        {
            player.GetComponent<MeshRenderer>().material = playerStats.whiteMaterial;
            playerStats.color = PlayerStats.colorState.white;
        }
    }
}
