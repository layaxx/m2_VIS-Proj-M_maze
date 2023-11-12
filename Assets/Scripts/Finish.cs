using TMPro;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Player player;

    public TMP_Text txt;

    // Start is called before the first frame update
    void Start()
    {
        player = (Player)FindFirstObjectByType(typeof(Player));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            if (player.score == 4)
            {
                Debug.Log("Finished: " + player.score);
                txt.text = "Congratulations, you finished the maze.";
            }
            else
            {
                Debug.Log("You have not yet collected all collectibles. Look in the corners of the maze.");
                if (txt.text.IndexOf("Look in the corners!") == -1)
                {   // only append help text if not already present
                    txt.text += "You need to collect all coins first. Look in the corners!";
                }
            }
        }
    }
}
