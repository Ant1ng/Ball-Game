using UnityEngine;
using System.Collections;

public class CameraController: MonoBehaviour {

    public GameObject player;
    public float StartAltitude;
    public float Radius;

    private Vector3 ballPosition;
    private Quaternion angle;

    private Rigidbody rb;
    private Rigidbody rb1;

    private bool boolean = true;
    
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb1 = player.GetComponent<Rigidbody>();
        rb.position = rb1.position;
        angle = rb1.rotation;
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
            if (boolean)
            {
                transform.RotateAround(player.transform.position, Vector3.up, number * 100 * Time.smoothDeltaTime);
            }
        }
    }
}
