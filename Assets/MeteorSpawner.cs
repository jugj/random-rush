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
    EventManager EventManager;
   // Start is called before the first frame update
    void Start()
    {
        EventManager=gameObject.GetComponent<EventManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(EventManager.rInt == 3){
            isActive = true;
        }

        if(isActive){
            if(timer == null){
                timer=gameObject.AddComponent<Timer>();
                timer.Ablaufzeit=2.5f;
            }
            if(timer.zeitabgelaufen()){
                 Instantiate(Meteor, Fusspilz.transform.position, Quaternion.identity);
                 Destroy(timer);
            }
        }
    }
}
