using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float degreePerSecond = 5f;

    private void Update()
    {
        transform.Rotate(Vector3.forward * degreePerSecond * Time.deltaTime);
    }
}
