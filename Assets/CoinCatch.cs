using UnityEngine;

public class CoinCatch : MonoBehaviour
{
    public static int count = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            count++;
            Destroy(gameObject);
        }
    }
}