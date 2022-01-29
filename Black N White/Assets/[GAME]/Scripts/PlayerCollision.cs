using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerStats ps;
    private void OnCollisionEnter(Collision collision)
    {
        if (ps.color == PlayerStats.colorState.white && gameObject.tag == "ObstacleBlack")
        {
            FindObjectOfType<GameManage>().Restart();
        }
        if (ps.color == PlayerStats.colorState.black && gameObject.tag == "ObstacleWhite")
        {
            FindObjectOfType<GameManage>().Restart();
        }
    }
}
