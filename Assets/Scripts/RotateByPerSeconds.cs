using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByPerSeconds : MonoBehaviour
{
    public float rotation;
    float startingRotation;
    public float seconds;
    float t = 0;
    void Start()
    {
        startingRotation = transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= seconds)
        {
            t = 0;
            startingRotation = transform.eulerAngles.z;
        };
        transform.localRotation = Quaternion.Euler(0, 0, Mathf.Lerp(startingRotation, startingRotation + rotation, t / seconds));
    }
}
