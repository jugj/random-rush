using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float Ablaufzeit;

    public Timer(float Ablaufzeit){
        this.Ablaufzeit = Ablaufzeit;
    }

    public bool zeitabgelaufen(){
        return Ablaufzeit<=0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ablaufzeit=Ablaufzeit-Time.deltaTime;
    }
}
