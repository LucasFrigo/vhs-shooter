using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRaycast : MonoBehaviour
{
    GameObject camera;
    void Update()
    {

        camera = GameObject.FindGameObjectWithTag("MainCamera");
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 100;
        Debug.DrawRay(camera.transform.position, forward, Color.green);
    }
}
