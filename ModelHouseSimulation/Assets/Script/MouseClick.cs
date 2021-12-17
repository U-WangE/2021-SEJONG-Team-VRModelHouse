using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public Camera getCamera;
    public GameObject interfacePlane;

    private RaycastHit hit;

    public string someObjectName;
    public static string objectName;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
                someObjectName = hit.collider.gameObject.name;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (someObjectName == hit.collider.gameObject.name)
                {
                    if (someObjectName == "go_home-icon-around")
                        ClosePanel();
                    else if (someObjectName == "leave_house-icon-around")
                        ExitSimulation();
                    else
                        objectName = someObjectName;
                }
                else
                    objectName = null;
            }
        }

        if (Input.GetMouseButtonUp(1) && !interfacePlane.activeSelf)
        {
            interfacePlane.SetActive(true);
        }
    }

    public void ExitSimulation()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // 어플리케이션 종료
#endif
    }

    public void ClosePanel()
    {
        interfacePlane.SetActive(false);
    }
}
