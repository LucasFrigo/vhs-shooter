// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class FPSCamera : MonoBehaviour
// {
//
//     public Transform playerBody;
//     public float mouseSensitivity;
//
//     float xAxisClamp = 0.0f;
//
//     void Awake()
//     {
//         Cursor.lockState = CursorLockMode.Locked;
//     }
//
//     void Update()
//     {
//         RotateCamera();
//     }
//
//     void RotateCamera()
//     {
//         float MouseX = Input.GetAxis("Mouse X");
//         float MouseY = Input.GetAxis("Mouse Y");
//
//         float rotAmountX = MouseX * mouseSensitivity;
//         float rotAmountY = MouseY * mouseSensitivity;
//
//         xAxisClamp -= rotAmountY;
//
//         Vector3 targetRotCam = transform.rotation.eulerAngles;
//         Vector3 targetRotBody = playerBody.rotation.eulerAngles;
//
//         targetRotCam.x -= rotAmountY;
//         targetRotCam.z = 0;
//         targetRotBody.y += rotAmountX;
//
//         if (xAxisClamp > 90)
//         {
//             xAxisClamp = 90;
//             targetRotCam.x = 90;
//         }
//         else if (xAxisClamp < -90)
//         {
//             xAxisClamp = -90;
//             targetRotCam.x = 90;
//         }
//
//
//         transform.rotation = Quaternion.Euler(targetRotCam);
//         playerBody.rotation = Quaternion.Euler(targetRotBody);
//     }
//
//
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour{
    public enum RotationAxis
    {
          MouseX = 1,
          MouseY = 2
    }

    public RotationAxis axes = RotationAxis.MouseX;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    public float sensHorizontal = 10.0f;
    public float sensVertical = 10.0f;

    public float _rotationX = 0;

    void Update (){
      if(axes == RotationAxis.MouseX){
          transform.Rotate(0, Input.GetAxis("Mouse X") * sensHorizontal, 0);

      }else if(axes == RotationAxis.MouseY){
        _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
        _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
        float rotationY = transform.localEulerAngles.y;

        transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
      }
    }
}
