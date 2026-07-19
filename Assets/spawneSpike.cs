using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawneSpike : MonoBehaviour
{
    public GameObject spike;
    public GameObject aktueller_spike;
    public float counter = 10f;

    void spawne(){
        this.aktueller_spike = Instantiate(spike, this.transform.position, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(counter+"");
        counter=counter-Time.deltaTime;
        if(counter <= 0){
            Destroy(aktueller_spike);
            counter = 10f;
        }
        if(counter <= 2 && aktueller_spike== null){
            Debug.Log("spawne Spike!");
            spawne();
        }
    }
}
