using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Switch : MonoBehaviour
{
    public GameObject[] light;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        try
        {
            if (MouseClick.objectName == gameObject.name)
            {
                if (light[0].activeInHierarchy)
                {
                    if (!MouseClick.objectName.Equals("LightTable06_1On"))
                        audioSource.Play();
                    light[0].SetActive(false);
                }
                else
                {
                    if (!MouseClick.objectName.Equals("LightTable06_1On"))
                        audioSource.Play();
                    for(int i = 0; i < light.Length; i++)
                        light[i].SetActive(true);
                }
                MouseClick.objectName = null;
            }
        }
        catch (Exception ex)
        {
            Debug.Log("Switch : " + ex);
        }
    }
}
