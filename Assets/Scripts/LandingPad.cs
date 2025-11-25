using UnityEngine;

public class LandingPad : MonoBehaviour
{
    public bool isLanded = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isLanded = true;
            Debug.Log("Landed successfully!");
        }
    }
}
