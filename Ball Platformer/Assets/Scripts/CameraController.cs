using UnityEngine;
using System.Collections;

public class CameraController: MonoBehaviour {

    public GameObject player;
    public float StartAltitude;
    public float Radius;

    private Rigidbody rb;
    private Rigidbody rb1;
    
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb1 = player.GetComponent<Rigidbody>();
        rb.position = rb1.position;
        rb.position = rb1.position + new Vector3(0.0f, StartAltitude, Radius);
		transform.LookAt (player.transform.position);
    }

    void FixedUpdate ()
    {
        rb.position = new Vector3(rb.position.x, rb1.position.y + StartAltitude, rb.position.z);
		transform.LookAt (player.transform.position);
    }

    public void Rotate (float number)
    {
        if (number != 0)
        {
            transform.RotateAround(player.transform.position, Vector3.up, number * 100 * Time.smoothDeltaTime);
        }
    }
}
