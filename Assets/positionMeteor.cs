using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionMeteor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=new Vector3(Random.Range(-9, 9), 6, 0);
    }
}
