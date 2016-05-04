using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    private Rigidbody rb;

    public float x;
    public float y;
    public float z;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        rb.velocity = new Vector3(x, y, z);
	}
}
