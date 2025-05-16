using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float lifespan = 5f;
    public GameObject explosionEffect;
    public GameObject coinPrefab;

    public AudioClip shootSound;
    public AudioClip explosionSound;

    void Start()
    {
        // ניגון סאונד ירייה
        if (shootSound != null)
        {
            AudioSource.PlayClipAtPoint(shootSound, transform.position);
        }

        Destroy(gameObject, lifespan);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zombie"))
        {
            // אפקט פיצוץ
            Instantiate(explosionEffect, other.transform.position, Quaternion.identity);

            // ניגון סאונד פיצוץ
            if (explosionSound != null)
            {
                AudioSource.PlayClipAtPoint(explosionSound, other.transform.position);
            }

            // יצירת מטבע
            Instantiate(coinPrefab, other.transform.position, Quaternion.identity);

            // השמדת הזומבי והכדור
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
