using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public int speed;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 1;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveUp = 0.0f;

        if (Input.GetKey(KeyCode.SPACE))
        {
        	if(rb.velocity.y == 0){
        		moveUp = 8.0f;
        	}
        }

        Vector3 movement = new Vector3(moveHorizontal, moveUp, moveVertical);
        rb.AddForce(movement * speed);
    }
}
