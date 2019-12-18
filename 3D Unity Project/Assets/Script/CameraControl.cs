using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform Camera, Target;

    public float speed = 3;

    private void Update()
    {

        Vector3 pos = Vector3.Lerp(Camera.position, Target.position, 0.5f * Time.deltaTime * speed);

        print(pos);

        Camera.position = pos;



    }
}
