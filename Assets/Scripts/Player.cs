using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float movementSpeed = 2f;
    private float rotationSpeed = 120f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move player with WASD keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, verticalInput) * movementSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, horizontalInput * rotationSpeed * Time.deltaTime, 0));
        // transform.rotation = Quaternion.Euler(0, 0, 0);


    }
}
