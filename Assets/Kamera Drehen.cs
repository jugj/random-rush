using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraDrehen : MonoBehaviour
{
    public float stepRotation = 45f;
    public float interval = 10f;

    // Total rotation in degrees
    public float totalRotation = 360f;
    // Rotation duration in seconds
    public float duration = 3f;
    private float rotationPerSecond;
    
    public void Start(){
        rotationPerSecond = totalRotation / duration;
    }

    public void StartRotating()
    {
        StartCoroutine(RotateStep());
        Debug.Log("Text");
    }

    public void StartRotating2()
    {
        StartCoroutine(RotateStep2());
        Debug.Log("Rotation2");
    }

    IEnumerator RotateStep()
    {
        while (true)
        {
            transform.Rotate(0f, 0f, stepRotation);
            yield return new WaitForSeconds(interval);
        }
    }

    IEnumerator RotateStep2()
    {
        while (true)
        {
            transform.Rotate(0f, rotationPerSecond * Time.deltaTime, 0f);
            yield return new WaitForSeconds(interval);
        }
    }

}
