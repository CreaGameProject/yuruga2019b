using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RemovePlayer : MonoBehaviour
{
    private Object Player;
    public StageManagement stageManager = new StageManagement();


    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = GameObject.Find("Player");


        if (other.gameObject.tag == "EnemyBullet")
        {
            Debug.Log("GAME OVER");
               
            stageManager.GameOver();
            // Destroy(obj,0.15f);

            // SceneManager.LoadScene("GameOver");
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
