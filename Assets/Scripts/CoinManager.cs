using UnityEngine;
using TMPro; // חשוב! מחלקת TextMeshPro

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    public int coinCount = 0;
    public TextMeshProUGUI coinText; // ← שינוי לסוג TextMeshProUGUI

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        coinCount++;
        UpdateUI();
    }

    void UpdateUI()
    {
        coinText.text = "Coin: " + coinCount;
    }
}
