using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieManager : MonoBehaviour
{
    void Update()
    {
        GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");

        if (zombies.Length == 0)
        {

            SceneManager.LoadScene(2);
        }
    }
}