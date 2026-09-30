using UnityEngine;


// A coin that adds points to the score when the player touches it
public class ScorePickup : MonoBehaviour
{
    // How many points this coin is worth
   [SerializeField] private int points = 10;


    // Called automatically when something enters this trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(points);

            // Remove the coin from the scene
            Destroy(gameObject);
        }
    }
}
