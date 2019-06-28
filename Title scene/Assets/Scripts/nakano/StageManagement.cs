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
        if (enemy != null)
        {
            return enemy.GetComponent<BarrageController>().Genbullet();
        }
        return null;
    }

    private IEnumerator Roll(){
        //gamestart

        //Mr Kino
        yield return wait(2);
        GameObject b1 = EnemySummon(-6, 5);
        Move(b1).speed = 3;
        Move(b1).direction = 270;
        yield return wait(1);
        GameObject b2 = EnemySummon(-3, 5);
        Move(b2).speed = 3;
        Move(b2).direction = 270;
        shot(b1);
        yield return wait(1);
        GameObject b3 = EnemySummon(-6, 5);
        Move(b3).speed = 3;
        Move(b3).direction = 270;
        shot(b2);
        yield return wait(1);
        GameObject b4 = EnemySummon(-3, 5);
        Move(b4).speed = 3;
        Move(b4).direction = 270;
        shot(b3);
        yield return wait(1);
        shot(b4);
        yield return wait(2);
        Destroy(b1);
        Destroy(b2);
        Destroy(b3);
        Destroy(b4);


        //Wai
        GameObject takao1 = EnemySummon(-4,6);
        GameObject takao2 = EnemySummon(-5,6);
        
        Move(takao1).speed = 3;
        Move(takao2).speed = 3;
        Move(takao1).direction = 240;
        Move(takao2).direction = 240;

        yield return wait(1);
        shot(takao1);
        shot(takao2);

        GameObject takao3 = EnemySummon(-3, 6);
        GameObject takao4 = EnemySummon(-4, 6);
        Move(takao3).speed = 3;
        Move(takao3).direction = 270;
        Move(takao4).speed = 3;
        Move(takao4).direction = 270;

        yield return wait(1);
        Destroy(takao1);
        Destroy(takao2);
        shot(takao3);
        shot(takao4);

        GameObject takao5 = EnemySummon(-9, 4);
        GameObject takao6 = EnemySummon(-10, 3);
        Move(takao5).speed = 3;
        Move(takao6).speed = 3;
        Move(takao5).direction = 0;
        Move(takao6).direction = 0;

        yield return wait(1);
        shot(takao5);
        shot(takao6);

        yield return wait(2);
        Destroy(takao3);
        Destroy(takao4);
        Destroy(takao5);
        Destroy(takao6);

        GameObject takao7 = EnemySummon(-7,6);
        Move(takao7).speed = 3;
        Move(takao7).direction = 270;
        GameObject takao8 = EnemySummon(-6,7);
        Move(takao8).speed = 3;
        Move(takao8).direction = 270;
        GameObject takao9 = EnemySummon(-5,8);
        Move(takao9).speed = 3;
        Move(takao9).direction = 270;
        GameObject takao10 = EnemySummon(-4,8);
        Move(takao10).speed = 3;
        Move(takao10).direction = 270;

        yield return wait(1);
        shot(takao7);
        yield return wait(0.3f);
        shot(takao8);
        yield return wait(0.1f);
        shot(takao9);
        shot(takao10);

        yield return wait(3);
        Destroy(takao7);
        Destroy(takao8);
        Destroy(takao9);
        Destroy(takao10);

        GameObject takao11 = EnemySummon(-7, -6);
        Move(takao11).speed = 3;
        Move(takao11).direction = 90;
        GameObject takao12 = EnemySummon(-2, -6);
        Move(takao12).speed = 3;
        Move(takao12).direction = 90;

        yield return wait(1);
        shot(takao11);
        shot(takao12);
        yield return wait(0.5f);
        shot(takao11);
        shot(takao12);
        yield return wait(0.5f);
        shot(takao11);
        shot(takao12);
        yield return wait(0.5f);
        shot(takao11);
        shot(takao12);

        yield return wait(2);
        Destroy(takao11);
        Destroy(takao12);

        GameObject takao13 = EnemySummon(12, 5);
        Move(takao13).speed = 3;
        Move(takao13).direction = 179;
        GameObject takao14 = EnemySummon(14, 4);
        Move(takao14).speed = 3;
        Move(takao14).direction = 179;
        GameObject takao15 = EnemySummon(13, 2);
        Move(takao15).speed = 3;
        Move(takao15).direction = 179;
        GameObject takao16 = EnemySummon(14, -1);
        Move(takao16).speed = 3;
        Move(takao16).direction = 179;

        yield return wait(1);

        for (int i = 0; i < 18; i++)
        {
            shot(takao13);
            shot(takao14);
            shot(takao15);
            shot(takao16);
            yield return wait(0.3f);
        }
       
        yield return wait(2);
        Destroy(takao13);
        Destroy(takao14);
        Destroy(takao15);
        Destroy(takao16);

        //ボス(仮)登場シーン
        yield return wait(2);
        GameObject takao18 = EnemySummon(-8, 2);
        Move(takao18).speed = 50;
        Move(takao18).direction = 45;
        yield return wait(1);
        GameObject takao19 = EnemySummon(-2, 6);
        Move(takao19).speed = 50;
        Move(takao19).direction = 270;
        yield return wait(1);
        GameObject takao20 = EnemySummon(-2, -5);
        Move(takao20).speed = 50;
        Move(takao20).direction = 110;
        yield return wait(1);
        Destroy(takao18);
        Destroy(takao19);
        Destroy(takao20);


        //ボス(仮)
        GameObject takao17 = EnemySummon(-5, 7);
        Move(takao17).hp = 10;
        Move(takao17).speed = 0.5f;
        Move(takao17).direction = 270;
        yield return wait(2);
        for(int i = 0; i < 68; i++)
        {
            if (takao17 != null)
            {
                shot(takao17);
                yield return wait(0.3f);
                Debug.Log(i);
            }
            else break;
        }

        yield return wait(2);
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
