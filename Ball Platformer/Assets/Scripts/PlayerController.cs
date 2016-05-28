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

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameController = gameControllerObject.GetComponent<GameController>();
        cameraController = cameraObject.GetComponent<CameraController>();
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
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
        float z = 0.0f;

        if (Input.GetKey(KeyCode.M))
        {
            z = jump;
        }

        if (x != 0)
        {
            cameraController.Rotate(x);
        }

        if (y != 0.0f)
        {
            print(cameraObject.transform.position.y);
            Vector3 movement = new Vector3 ((rb.position.x - cameraObject.transform.position.x), 0.0f, (rb.position.z - cameraObject.transform.position.z));
			transform.Translate((movement/movement.magnitude) * speed * y * Time.smoothDeltaTime);
            print((movement / movement.magnitude) * speed * y * Time.smoothDeltaTime);
            cameraObject.transform.Translate((movement / movement.magnitude) * speed * y * Time.smoothDeltaTime);
       }
    }
}
