using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;

    public float speed;
    public float jump;

    private CameraController cameraController;
    public GameObject cameraObject;

    private GameController gameController;
    public GameObject gameControllerObject;

    private float radius;

    // Use this for initialization
    void Start()
    {
        gameController = gameControllerObject.GetComponent<GameController>();
        cameraController = cameraObject.GetComponent<CameraController>();
        rb = GetComponent<Rigidbody>();
        radius = (rb.transform.position - cameraObject.transform.position).magnitude;
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Movement();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("shit"))
        {
            other.gameObject.SetActive(false);
            gameController.addScore(1);
        }
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //float z = 0.0f;

        if (Input.GetKey(KeyCode.M))
        {
            //rb.AddForce(new Vector3 (0.0f, jump, 0.0f));
        }

        if (x != 0)
        {
            cameraController.Rotate(x);
        }

        if (y != 0.0f)
        {
            Vector3 movement = new Vector3((rb.position.x - cameraObject.transform.position.x), 0.0f, (rb.position.z - cameraObject.transform.position.z));
            print (movement);
            transform.Translate((movement / movement.magnitude) * speed * y * Time.smoothDeltaTime);
            print(movement);
            Vector3 cameraMovement = new Vector3(rb.transform.position.x + cameraController.Radius * Mathf.Cos(cameraObject.transform.rotation.y), 
                                                cameraController.StartAltitude + rb.position.y, 
                                                rb.transform.position.z + cameraController.Radius * Mathf.Sin(cameraObject.transform.rotation.y));
            //cameraObject.transform.position = cameraMovement;
            cameraObject.transform.Translate((movement / movement.magnitude) * speed * y * Time.smoothDeltaTime);

            //Vector3 movement = new Vector3((rb.position.x - cameraObject.transform.position.x), 0.0f, (rb.position.z - cameraObject.transform.position.z));
            //transform.Translate((movement / movement.magnitude) * speed * y * Time.smoothDeltaTime);
            //cameraObject.transform.Translate((movement / movement.magnitude) * speed * y * Time.smoothDeltaTime);

        }
    }
}
