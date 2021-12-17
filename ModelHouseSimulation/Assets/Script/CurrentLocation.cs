using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLocation : MonoBehaviour
{
    static public int location = 0;

    //  현관, 화장실, L1, L2, L2-1, Bed, mini, Balcony
    Vector3[] vec = { new Vector3(-0.182f,-1.458f,0), new Vector3(0.161f, -1.346f, 0)
                        , new Vector3(0.083f, -0.922f, 0), new Vector3(0.585f, -0.909f, 0)
                            , new Vector3(0.585f, -1.337f, 0), new Vector3(-0.412f, -0.953f, 0)
                                , new Vector3(-0.459f, -1.381f, 0), new Vector3(-0.775f, -0.928f, 0)};

    void Update()
    {
        gameObject.transform.localPosition = vec[location];
    }
}
