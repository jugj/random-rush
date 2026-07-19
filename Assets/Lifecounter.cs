using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifecounter : MonoBehaviour
{
    public Slider sliderleben;
    private float timePassed = 0f;

    public void maxlife(int leben)
    {
        sliderleben.maxValue = leben;
        sliderleben.value = leben;
    }
    
    void Update()
    {
    
    timePassed += Time.deltaTime;

    if(timePassed > 1f)
    {
        if(sliderleben.value <= 0)
        {
            setzeleben(9f);
        }
        else
        {
            setzeleben(sliderleben.value-1);
        }
        
        timePassed = 0f;
    }
    }

    public void setzeleben(float leben)
        {
            sliderleben.value = leben;
        }
    
}
