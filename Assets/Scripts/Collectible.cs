using TMPro;
using UnityEngine;

public class Collectible : MonoBehaviour
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
        // Increase Score of player
        player.score++;

        Debug.Log("Good job, you collected " + name);
        txt.text = "You have collected " + player.score + "/4 coins.";

        // remove this collectible
        Destroy(gameObject);
    }
}
