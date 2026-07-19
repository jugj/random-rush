using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    float timePassed = 0f;
    public int rInt;
    public Flashbang flashbang;
    [SerializeField]
    GameObject Camera;
    public bool CameraRotatingActive = false;


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
            if(rInt == 2) {
                if(!CameraRotatingActive)
                {
                    CameraRotatingActive = true;
                    Camera.GetComponent<KameraDrehen>().StartRotating();
                    Debug.Log("string");
                }
                else
                {
                    rInt = Random.Range(1, 7);
                    Debug.Log("Zahl: " + rInt);
                }
            }
            
            rInt = Random.Range(1, 7);
            Debug.Log("Zahl: " + rInt);


            


            timePassed = 0f;
        }
    }
}
