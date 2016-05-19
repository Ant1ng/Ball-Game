using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    public GameObject wall1;
    public GameObject wall2;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(x, y, z);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == wall1 || other.gameObject == wall2)
            y = -y;
    }
}
