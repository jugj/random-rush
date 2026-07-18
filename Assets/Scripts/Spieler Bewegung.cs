using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.SceneManagement;

public class SpielerBewegung : MonoBehaviour
{   [SerializeField]
    float geschwindigkeit = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a")){
            transform.Translate(Vector2.left*Time.deltaTime*geschwindigkeit);
        }
        
        if(Input.GetKey("d")){
            transform.Translate(Vector2.right*Time.deltaTime*geschwindigkeit);
        }
        
    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("KillObject")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
