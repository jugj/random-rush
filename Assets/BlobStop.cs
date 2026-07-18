using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobStop : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other)
    {
       Debug.Log("Kollision: " + other.gameObject.name);
       BlobMovement mov = other.gameObject.GetComponent<BlobMovement>();
       mov.left = !mov.left;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
