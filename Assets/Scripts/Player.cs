using UnityEngine;

public class Player : MonoBehaviour
{
    public int score = 0;
    private readonly float movementSpeed = 3f;
    private readonly float rotationSpeed = 150f;

    // Update is called once per frame
    void Update()
    {
        // Move player with WASD keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(movementSpeed * Time.deltaTime * new Vector3(0, 0, verticalInput));
        transform.Rotate(new Vector3(0, horizontalInput * rotationSpeed * Time.deltaTime, 0));

        // Quit game with ESC
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
