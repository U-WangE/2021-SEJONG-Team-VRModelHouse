using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public float turnSpeed = 4.0f; // 마우스 회전 속도

    public Camera mainCamera;

    Vector3 vec = new Vector3(0, 2f, 0);

    void Update()
    {
        mainCamera.transform.position = transform.position + vec;

        MouseRotation();
    }

    void MouseRotation()
    {
        if (Input.GetMouseButton(0))
        {
            // 좌우로 움직인 마우스의 이동량 * 속도에 따라 카메라가 좌우로 회전할 양 계산
            float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
            // 현재 y축 회전값에 더한 새로운 회전각도 계산
            float yRotate = transform.eulerAngles.y + yRotateSize;

            // 카메라 회전량을 카메라에 반영(X, Y축만 회전)
            transform.eulerAngles = new Vector3(0, yRotate, 0);
        }
    }
}
