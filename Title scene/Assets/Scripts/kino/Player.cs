using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int count = 0;
    int interval = 15;
    public float speed;
    public float shootForce;
    public GameObject BulletsPrefab;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;

        count += count < interval ? 1 : 0;
        if (Input.GetKey(KeyCode.Z) && count >= interval)
        {
            count = 0;
            GameObject Bullets = Instantiate(BulletsPrefab, transform.position, transform.rotation) as GameObject;
            //Bullets.GetComponent<Rigidbody>().AddForce(Bullets.transform.forward * shootForce);
        }
        
    }
}
