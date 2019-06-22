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

    private IEnumerator Roll(){
        //gamestart

        int a = 0;
        while(a == 0){
            yield return null;
        }

        //clear
        IEnumerator end = BattleEnd(Roll(), true);
        StartCoroutine(end);
        yield break;
    }

    private IEnumerator BattleEnd(IEnumerator stop, bool clear){
        StopCoroutine(stop);
        GameObject image = clear ? clearImage : gameoverImage;
        image.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Titlescene");
        yield break;
    }
}
