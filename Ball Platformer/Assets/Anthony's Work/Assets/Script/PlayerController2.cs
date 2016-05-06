using UnityEngine;
using System.Collections;

public class PlayerController2 : MonoBehaviour {

    private Rigidbody rb;

    public float speed;
    public float forceMag;
    
    // Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        //bool force = false;

        Vector3 v = rb.velocity;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float z = 0.0f;

        //if (v.y >= 0.5f || v.y <= -0.5f)
        //{
        //    force = true;
        //}

        if (Input.GetKey(KeyCode.M) && rb.velocity.y == 0.0f)
        {
            z = 5.0f;
        }

        v.x = speed * x;
        v.y = v.y + z;
        v.z = speed * y;

        //if (!force)
        //{
            rb.velocity = v;
        //}

        //if (force)
        //{
        //    rb.AddForce(forceMag * new Vector3(x, y, z));
        //}
    }
}
