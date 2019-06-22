using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed = 15;
    //public GameObject bParent;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
        //transform.parent = bParent.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;

        if(transform.position.y>20)
        {
            Destroy(gameObject);
        }
    }
}
    
        
     
