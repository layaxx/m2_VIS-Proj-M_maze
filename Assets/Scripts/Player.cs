using UnityEngine;

public class Player : MonoBehaviour
{
    public int score = 0;
    private float movementSpeed = 3f;
    private float rotationSpeed = 150f;

    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        // Move player with WASD keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, verticalInput) * movementSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, horizontalInput * rotationSpeed * Time.deltaTime, 0));
    }
}
