using UnityEngine;

public class Finish : MonoBehaviour
{
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = (Player)FindFirstObjectByType(typeof(Player));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            if (player.score == 4)
            {
                Debug.Log("Finished: " + player.score);
            }
            else
            {
                Debug.Log("You have not yet collected all collectibles. Look in the corners of the maze.");
            }
        }
    }
}
