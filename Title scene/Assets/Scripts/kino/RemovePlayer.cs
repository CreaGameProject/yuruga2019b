using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RemovePlayer : MonoBehaviour
{
    private Object Player;


    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = GameObject.Find("Player");

        Debug.Log("GAME OVER");        

        if (other.gameObject.tag == "EnemyBullet")
        {
        
            Destroy(obj,0.15f);

            SceneManager.LoadScene("GameOver");
        }

    }
    //void OnCollisionEnter(Collision collision)
    //{
    //GameObject obj = GameObject.Find("Player");

    //if (collision.gameObject.name == "Player")
    //{

    //}
    //}

}
