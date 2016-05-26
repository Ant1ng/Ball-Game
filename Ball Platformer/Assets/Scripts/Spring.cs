using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour
{
    public float springStrength;
    public GameObject ball;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.GetComponent<Spring>().enabled)
            other.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, springStrength, 0.0f);
    }
}
