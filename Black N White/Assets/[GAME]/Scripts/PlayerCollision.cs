using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
