using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 100f; // מהירות גבוהה יותר (מומלץ בין 50–200)

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = firePoint.forward * bulletSpeed; // חשוב: velocity ולא linearVelocity
        Destroy(bullet, 5f); // יהרוס את הקליע אחרי 5 שניות (כדי שלא יעמיס על המשחק)
    }
}
