using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float direction;
    public float speed;

    public int hp;
    public int damage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayerBullet")
        {
            // 弾と衝突したのでダメージ処理
            Debug.Log("hit");
            hp = hp - damage;
            Destroy(other.gameObject);
        }
    }

    void Start()
    {
        
        Vector2 v;
        v.x = Mathf.Cos(Mathf.Deg2Rad * direction) * speed;
        v.y = Mathf.Sin(Mathf.Deg2Rad * direction) * speed;

        Rigidbody2D rd = GetComponent<Rigidbody2D>();
        rd.velocity = v;

    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("aaaaa");
        }
    }
}
