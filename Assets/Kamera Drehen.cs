using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraDrehen : MonoBehaviour
{
    public float stepRotation = 24f;
    public float interval = 11f;

    public void StartRotating()
    {
        StartCoroutine(RotateStep());
    }

    IEnumerator RotateStep()
    {
        while (true)
        {
            transform.Rotate(0f, 0f, stepRotation);
            yield return new WaitForSeconds(interval);
        }
    }
}
