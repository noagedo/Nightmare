using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject intText;        
    public Animator doorAnim;         
    public string playerTag = "Player";

    private bool interactable = false;
    private bool isOpen = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if (interactable && Input.GetKeyDown(KeyCode.E))
        {
            ToggleDoor();
            intText.SetActive(false);
            interactable = false;
        }
    }

    void ToggleDoor()
    {
        if (isOpen)
        {
            doorAnim.ResetTrigger("open");
            doorAnim.SetTrigger("close");
        }
        else
        {
            doorAnim.ResetTrigger("close");
            doorAnim.SetTrigger("open");
        }

        isOpen = !isOpen;
    }
}
