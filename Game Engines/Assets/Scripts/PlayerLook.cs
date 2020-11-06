using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float TheSensitivityOfMouse = 100f;
    public Transform CharcaterBody;
    float RotationOfX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float xMouse = Input.GetAxis("Mouse X") * TheSensitivityOfMouse * Time.deltaTime;
        float yMouse = Input.GetAxis("Mouse Y") * TheSensitivityOfMouse * Time.deltaTime;

        RotationOfX -= yMouse;
        RotationOfX = Mathf.Clamp(RotationOfX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(RotationOfX, 0f, 0f);
        CharcaterBody.Rotate(Vector3.up * xMouse);
    }
}
