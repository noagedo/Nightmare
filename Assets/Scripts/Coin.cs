using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager.instance.AddCoin(); // ← עדכון הספירה
            Destroy(gameObject);           // השמדת המטבע
        }
    }
}
