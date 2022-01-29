using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerStats ps;
    private void OnTriggerEnter(Collider col)
    {
        if (ps.color == PlayerStats.colorState.white && gameObject.tag == "ObstacleBlack")
        {
            FindObjectOfType<GameManage>().Restart();
        }
        if (ps.color == PlayerStats.colorState.black && gameObject.tag == "ObstacleWhite")
        {
            FindObjectOfType<GameManage>().Restart();
        }
        if (ps.color == PlayerStats.colorState.white && gameObject.tag == "ObstacleWhite")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        if (ps.color == PlayerStats.colorState.black && gameObject.tag == "ObstacleBlack")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}