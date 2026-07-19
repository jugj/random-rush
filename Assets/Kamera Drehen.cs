using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraDrehen : MonoBehaviour
{
    public float stepRotation = 45f;
    public float interval = 10f;

    public void StartRotating()
    {
        StartCoroutine(RotateStep());
        Debug.Log("Text");
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
