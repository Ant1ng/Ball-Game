using UnityEngine;
using System.Collections;

public class CameraController: MonoBehaviour {

    public GameObject player;
    public Vector3 offset;

    private Vector3 ballPosition;
    private Quaternion angle;

    private Rigidbody rb;
    private Rigidbody rb1;
        
    void Postion(GameObject ball)
    {
        player = ball;
    }
    
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb1 = player.GetComponent<Rigidbody>();
        rb.position = rb1.position + offset;
        angle = rb1.rotation;
    }

    void Update ()
    {
        rb.position = rb1.position + offset;
	}
}
