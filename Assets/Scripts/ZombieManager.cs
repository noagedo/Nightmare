using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ZombieManager : MonoBehaviour
{
    public TextMeshProUGUI zombieCounterText; 

    private int lastZombieCount = -1; 

    void Update()
    {
        GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");
        int count = zombies.Length;

        if (count != lastZombieCount)
        {
            UpdateZombieText(count);
            lastZombieCount = count;
        }

        if (count == 0)
        {
            LoadVictoryScene();
        }
    }

    void UpdateZombieText(int count)
    {
        if (zombieCounterText != null)
            zombieCounterText.text = "Zombies Left: " + count;
    }

    void LoadVictoryScene()
    {
        
        SceneManager.LoadScene(2);
    }
}
