using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraDrehen : MonoBehaviour
{
    public float stepRotation = 24f;
    public float interval = 10f;

    void StartRotating()
    {
        StartCoroutine(RotateStep());
    }

    IEnumerator RotateStep()
    {
        while (true)
        {
            transform.Rotate(0f, stepRotation, 0f);
            yield return new WaitForSeconds(interval);
        }
    }
}
