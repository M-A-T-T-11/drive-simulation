using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float mouseSensitivity = 150;
    private float xAxisClamp = 0;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > 90)
        {
            xAxisClamp = 90;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(270f);
        } else if (xAxisClamp < -90f)
        {
            xAxisClamp = -90f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(90.0f);
        }

        transform.Rotate(Vector3.left * mouseY);
        transform.Rotate(Vector3.up * mouseX);
    }

    private void ClampXAxisRotationToValue(float val)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = val;
        transform.eulerAngles = eulerRotation;
    }

}
