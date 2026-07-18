using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.SceneManagement;

public class SpielerBewegung : MonoBehaviour {
    [SerializeField]
    public float geschwindigkeit = 3f;
    
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a")){
            transform.Translate(Vector2.left*Time.deltaTime*geschwindigkeit);
            anim.SetBool("PlayerMoving", true);
            anim.SetBool("PlayerLeft", true);
            Debug.Log("lll");
        }
        else if(Input.GetKey("d")){
            transform.Translate(Vector2.right*Time.deltaTime*geschwindigkeit);
            anim.SetBool("PlayerMoving", true);
            anim.SetBool("PlayerLeft", false);
            Debug.Log("rrr");
        }
        else {
            anim.SetBool("PlayerMoving", false);
            Debug.Log("asss");
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
