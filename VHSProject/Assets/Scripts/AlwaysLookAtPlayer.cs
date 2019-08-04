using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysLookAtPlayer : MonoBehaviour
{
    public Transform go;

    void Start(){

    }

    void Update()
    {
        transform.LookAt(go, Vector3.up);

    }
}
