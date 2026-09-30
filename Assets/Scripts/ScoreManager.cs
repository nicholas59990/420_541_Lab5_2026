using UnityEngine;

// Keeps track of the player's score
// It is a singleton: there is only ever one, reachable from any script through ScoreManager.Instance
public class ScoreManager : MonoBehaviour
{

    // The single shared instance that any script can reach
    public static ScoreManager Instance { get; private set; }

    public int Score { get; private set; }

    // Awake can read the score, only Scoremanager can change it
    private void Awake()
    {
        // If a ScoreManager already exists, remove this extra component
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        // Otherwise, this is the one and only ScoreManager
        Instance = this;
    }

    // Called by coins when they're collected
    public void AddScore(int amount)
    {
        Score += amount;

        // Print the new total to the Console window
        Debug.Log("Score: " + Score);
    }
}
