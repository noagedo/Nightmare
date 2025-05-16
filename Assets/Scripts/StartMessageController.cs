using UnityEngine;
using UnityEngine.UI;

public class StartMessageController : MonoBehaviour
{
    public GameObject startText;    
    public float displayTime = 5f;  

    void Start()
    {
        startText.SetActive(true);               
        Invoke("HideMessage", displayTime);      
    }

    void HideMessage()
    {
        startText.SetActive(false);
    }
}