using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer_script : MonoBehaviour
{
    static float minAngle = 584f;
    static float maxAngle = 215f;
    static Pointer_script thisSpeedo;

    void Start()
    {
        thisSpeedo = this;   
    }

    public static void ShowSpeed(float speed, float min, float max)
    {
        float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed));
        thisSpeedo.transform.eulerAngles = new Vector3(0, 0, ang);
    }
}
