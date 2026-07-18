using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool continueLoop;
        DateTime decayLimit = DateTime.Now.AddSeconds(-1);
        do {
            continueLoop = false;
            if (FrameCounter.Count > 0 && FrameCounter[0] < decayLimit) {
                
            }
    }
}
