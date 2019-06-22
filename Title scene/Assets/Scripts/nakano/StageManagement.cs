using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManagement : MonoBehaviour
{
    public GameObject clearImage;
    public GameObject gameoverImage;
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Roll());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject EnemySummon(float x, float y){
        return GameObject.Instantiate(enemyPrefab, new Vector2(x,y), Quaternion.identity);
    }
    
    public void GameOver(){
        //Debug.Log("eapvrpaevearb");
        IEnumerator end = BattleEnd(Roll(), false);
        StartCoroutine(end);
    }

    private EnemyMove Move(GameObject enemy){
        return enemy.GetComponent<EnemyMove>();
    }

    private IEnumerator wait(float second){
        yield return new WaitForSeconds(second);
    }

    private GameObject shot(GameObject enemy){
        return enemy.GetComponent<BarrageController>().Genbullet();
    }

    private IEnumerator Roll(){        
        //gamestart

    //     藤川
    //     yield return wait(3);
    //     GameObject f1=EnemySummon()

        // GameObject a1 = EnemySummon(-3,6);
        // GameObject a2 = EnemySummon(-4,6);
        // Move(a1).speed = 3;
        // Move(a2).speed = 3;
        // Move(a1).direction = 210;
        // Move(a2).direction = 210;
        // yield return wait(1);
        // shot(a1);
        // shot(a2);
        // yield return wait(3);
        // Destroy(a1);
        // Destroy(a2);

    //     木野
    //     yield return wait(3);
    //     GameObject b1 = EnemySummon(-4,5);
    //     GameObject b2 = EnemySummon(-4,3);
    //    GameObject b3 = EnemySummon()


    //     中野
    //     yield return wait(1);
    //     GameObject n1 = EnemySummon(-5, 8);
    //     nnseta = 
    //     Vector2 nn1 = n1.GetComponent<Transform>().position + new Vector2();
        

        //clear

        IEnumerator end = BattleEnd(Roll(), true);
        StartCoroutine(end);
        yield break;
    }

    private IEnumerator BattleEnd(IEnumerator stop, bool clear){
        foreach(GameObject d in GameObject.FindGameObjectsWithTag("EnemyBullet")){
            Destroy(d);
        }
        StopCoroutine(stop);
        GameObject image = clear ? clearImage : gameoverImage;
        image.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Titlescene");
        yield break;
    }
}
