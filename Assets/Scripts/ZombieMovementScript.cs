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
        if (justCollided) return; // הגנה מסיבובים מיותרים

        justCollided = true;

        // תזוזה קצת אחורה כדי להתרחק מהקיר
        transform.Translate(-Vector3.forward * 0.5f);

        // סיבוב אקראי
        float randomY = Random.Range(90f, 270f);
        transform.Rotate(0, randomY, 0);

        // להחזיר את המצב לקדמותו אחרי חצי שנייה
        Invoke("ResetCollision", 0.5f);
    }

    private void ResetCollision()
    {
        justCollided = false;
    }
}
