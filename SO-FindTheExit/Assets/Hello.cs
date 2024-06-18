using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    bool j = false;
    string h = "Hello";
    float o = 0.1f;
    double r = 0.56;
    int k = 1;




    // Start is called before the first frame update
    void Start()
    {
        Hi("Hola");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Hi(string n)
    {
        h = n;
        Debug.Log(h);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
    }
 
    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log("STAY");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("Bye");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
           
    }
}
