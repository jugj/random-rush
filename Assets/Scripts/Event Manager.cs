using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    float timePassed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if(timePassed > 10f)
        {
            int rInt = Random.Range(1, 21);
            Debug.Log("Zahl: " + rInt);

            if(rInt == 1) {

            }


            timePassed = 0f;
        }
    }
}
