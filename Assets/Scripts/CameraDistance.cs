using UnityEngine;

public class CameraDistance : MonoBehaviour
{

    private float progress = 0.15f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);

        Debug.Log(transform.localPosition);

    }

    // Update is called once per frame
    void Update()
    {
        float speed = Input.GetAxis("Mouse ScrollWheel") * 50;

        //move towards the center of the world (or where ever you like)
        progress = Mathf.Clamp(progress + speed * Time.deltaTime, 0.05f, 1);

        transform.SetLocalPositionAndRotation(
            new Vector3(0, 01f, -3f) + (3 * progress * new Vector3(0, 4.5f, 1f)),
            Quaternion.Euler(5 + (70 * progress), 0, 0)
        );
    }
}
