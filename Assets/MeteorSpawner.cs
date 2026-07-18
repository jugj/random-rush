using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    private bool isActive = false;
    private Timer timer;
    [SerializeField]
    GameObject Fusspilz;
    [SerializeField]
    GameObject Meteor;
    int rInt = 3;
   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rInt == 3){
            isActive = true;
        }

        if(isActive){
            if(timer == null){
                timer=new Timer(2.5f);
            }
            if(timer.zeitabgelaufen()){
                 Instantiate(Meteor, Fusspilz.transform.position, Quaternion.identity);
            }
        }
    }
}
