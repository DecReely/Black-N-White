using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerStats ps;
    private void OnCollisionEnter(Collision collision)
    {
        if(ps.GetComponent("colorState") && collision.collider.tag == "ObstacleBlack")
        {

        }
        if (ps.GetComponent("colorState") && collision.collider.tag == "ObstacleWhite")
        {

        }
    }
