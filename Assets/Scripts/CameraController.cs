using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerBody;
    public Transform cameraPivot; 
    public float mouseSensitivity = 100f;

    private float xRotation = 0f;
    private float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        yRotation = playerBody.eulerAngles.y;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -45f, 45f); 
        cameraPivot.localRotation = Quaternion.Euler(xRotation, 0f, 0f); 

        yRotation += mouseX;
        yRotation = Mathf.Clamp(yRotation, -179f, 179f);
        playerBody.localRotation = Quaternion.Euler(0f, yRotation, 0f);
    }
}
