using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private float speed = 0.1f;
    private Vector2 vec;
    public GameObject player;
    public GameObject enemy;
    //public GameObject bParent;
    // Start is called before the first frame update
    void Start()
    {
        //transform.parent = bParent.GetComponent<Transform>();
        Vector2 enemypos = enemy.GetComponent<Transform>().position;
        Vector2 playerpos = player.GetComponent<Transform>().position;
        Vector2 diff = playerpos - enemypos;
        float angle = Mathf.Atan2(diff.y, diff.x);
        vec = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vec * speed);
        if (Mathf.Abs(transform.position.x) > 10 || Mathf.Abs(transform.position.y) > 7)
        {
            Destroy(gameObject);
        }
    }
}
