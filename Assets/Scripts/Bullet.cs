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
            
            Instantiate(explosionEffect, other.transform.position, Quaternion.identity);

            
            if (explosionSound != null)
            {
                AudioSource.PlayClipAtPoint(explosionSound, other.transform.position);
            }

           
            Instantiate(coinPrefab, other.transform.position, Quaternion.identity);

            
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
