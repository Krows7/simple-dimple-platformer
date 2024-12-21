using UnityEngine;
using TMPro;

public class RenderCoins : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = "Coins: " + CoinCatch.count;
    }
}
