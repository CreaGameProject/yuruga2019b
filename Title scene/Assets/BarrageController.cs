using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrageController : MonoBehaviour
{
    public  GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Genbullet", 2f, 0.5f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Genbullet()
    {
        GameObject bulletIns = GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
        BulletController bulletInsComp = bulletIns.GetComponent<BulletController>();
        bulletInsComp.enemy = gameObject;
        bulletInsComp.player = GameObject.FindWithTag("Player");
    }
}
