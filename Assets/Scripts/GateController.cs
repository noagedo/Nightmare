using UnityEngine;

public class GateController : MonoBehaviour
{
    public GameObject intText;
    public bool interactable, toggle;
    public Animator doorAnim;

    void Start()
    {
        
        doorAnim.SetTrigger("open");
        toggle = true;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if (interactable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;

                if (toggle)
                {
                    doorAnim.ResetTrigger("close");
                    doorAnim.SetTrigger("open");
                }
                else
                {
                    doorAnim.ResetTrigger("open");
                    doorAnim.SetTrigger("close");
                }

                intText.SetActive(false);
                interactable = false;
            }
        }
    }
}
