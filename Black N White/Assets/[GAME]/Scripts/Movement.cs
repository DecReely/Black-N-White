using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour{
    public Rigidbody rb;
    public Transform PlayerTransform;
    public Transform targetTransform;
    public float forward_speed = 10f;
    public float side_speed = 1000f;

    void FixedUpdate(){

        //rb.AddForce(0, 0, forward_speed * Time.deltaTime);
        PlayerTransform.position = Vector3.MoveTowards(PlayerTransform.position, targetTransform.position, 0.15f);;
        
        if (Input.GetKey("a")){
            rb.AddForce(-side_speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d")){
            rb.AddForce(side_speed * Time.deltaTime, 0, 0);
        }
       
    }
}
