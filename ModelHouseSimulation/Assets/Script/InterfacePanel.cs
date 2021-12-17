using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfacePanel : MonoBehaviour
{
    public Camera camera;

    void Update()
    {
        gameObject.transform.position = camera.transform.position;
        gameObject.transform.rotation = camera.transform.rotation;
    }
}
