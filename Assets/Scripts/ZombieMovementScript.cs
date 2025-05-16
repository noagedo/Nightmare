using UnityEngine;

public class ZombieMovementScript : MonoBehaviour
{
    public float speed = 2f;
    private bool justCollided = false;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (justCollided) return;

        justCollided = true;

        
        transform.Translate(-Vector3.forward * 0.5f);

      
        float randomY = Random.Range(90f, 270f);
        transform.Rotate(0, randomY, 0);

        
        Invoke("ResetCollision", 0.5f);
    }

    private void ResetCollision()
    {
        justCollided = false;
    }
}
