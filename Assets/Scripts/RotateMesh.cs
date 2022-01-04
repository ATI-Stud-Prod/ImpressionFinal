using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMesh : MonoBehaviour
{
    public float RotateSpeed = 10.0f;

    float accelx, accely, accelz = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        accelx = Input.acceleration.x;
        accely = Input.acceleration.y;
        accelz = Input.acceleration.z;
        transform.Rotate(accelx * Time.deltaTime, accely * Time.deltaTime, RotateSpeed * Time.deltaTime);
    }
}