using UnityEngine;

public class Movement : MonoBehaviour{
    public Rigidbody rb;
    public float forward_speed = 1000f;
    public float side_speed = 1000f;

    void FixedUpdate(){

        rb.AddForce(0, 0, forward_speed * Time.deltaTime);

        if (Input.GetKey("a")){
            rb.AddForce(-side_speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d")){
            rb.AddForce(side_speed * Time.deltaTime, 0, 0);
        }
       
    }
}
