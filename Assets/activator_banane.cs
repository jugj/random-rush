using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator_banane : MonoBehaviour
{
    [SerializeField]
    GameObject triangle;
    int four = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int rInt = GetComponent<EventManager>().rInt;
        Debug.Log("sdasd"+rInt);
        if(rInt == 4){
            triangle.SetActive(true);
        }

    }
}
