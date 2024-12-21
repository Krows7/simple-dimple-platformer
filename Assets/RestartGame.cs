using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public Transform platform;

    void Update()
    {
        if (transform.position.y + 1f < platform.position.y) GameOver();
    }

    void GameOver()
    {
        CoinCatch.count = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}