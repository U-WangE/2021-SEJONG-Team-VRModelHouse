using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject[] roomPlane;

    void Update() {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal")*Time.deltaTime*5,
            0,
            Input.GetAxis("Vertical")*Time.deltaTime*5);

        transform.Translate(vec);
    }
    
    private void OnTriggerStay(Collider other) {
        for(int i = 0; i < 8; i++)
            if(other.name == roomPlane[i].name)
            {
                CurrentLocation.location = i;
            }
    }
}
