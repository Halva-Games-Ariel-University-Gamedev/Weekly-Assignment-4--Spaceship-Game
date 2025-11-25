using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlanetWin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You Win!");
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
