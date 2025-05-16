using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;  // הגוף של השחקן (Player)

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; // אם לא רוצים לראות את הסמן
    }

    void Update()
    {
        // תנועה של העכבר
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // סיבוב המצלמה למעלה ולמטה (ציר X)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);  // סיבוב המצלמה על ציר ה-X

        // סיבוב השחקן ימינה ושמאלה (ציר Y)
        playerBody.Rotate(Vector3.up * mouseX);  // סיבוב השחקן
    }
}
