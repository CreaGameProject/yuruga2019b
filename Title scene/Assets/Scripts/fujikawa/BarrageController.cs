using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrageController : MonoBehaviour
{
    public GameObject bullet;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject Genbullet()
    {
        GameObject bulletIns = GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
        BulletController bulletInsComp = bulletIns.GetComponent<BulletController>();
        bulletInsComp.enemy = gameObject;
        bulletInsComp.player = player;
        return bulletIns;
    }
}
