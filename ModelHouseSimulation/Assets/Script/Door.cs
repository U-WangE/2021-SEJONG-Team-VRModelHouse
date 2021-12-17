using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Door : MonoBehaviour
{
    public int degree;
    int OpenClose;
    float yRotate;
    AudioSource audioSource;
    public AudioClip[] audioClips;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        OpenClose = 0;
    }

    void Update()
    {
        try{
            if(name == MouseClick.objectName) {
                if(OpenClose == 0)
                {
                    // 현재 y축 회전값에 더한 새로운 회전각도 계산
                    yRotate = transform.eulerAngles.y + degree;
                    OpenClose = 1;
                    audioSource.clip = audioClips[0];
                    audioSource.Play();
                    MouseClick.objectName = null;
                }
                else
                {
                    // 현재 y축 회전값에 더한 새로운 회전각도 계산
                    yRotate = transform.eulerAngles.y - degree;
                    OpenClose = 0;
                    audioSource.clip = audioClips[1];
                    audioSource.Play();
                    MouseClick.objectName = null;
                }
                // 카메라 회전량을 카메라에 반영(X, Y축만 회전)
                transform.eulerAngles = new Vector3(0, yRotate, 0);
            }
        }catch(Exception ex) {
            Debug.Log("Door : " + ex);
        }
    }
}
