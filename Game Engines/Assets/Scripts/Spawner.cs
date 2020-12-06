using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Spawner : MonoBehaviour
{
    public int spawnRateEnemies = 2;
    public int enemyAmoundMax = 10;
    public TextMeshProUGUI Enemys;
    public  int count = 0;
    public  int totalcount = 0;
    public GameObject enemyPrefab;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private int EnemyIndex;
    public bool isFound;
public bool spawning =  true;
   public void SpawnEnemy()
   {
       if(count < enemyAmoundMax && spawning == true)
        {
        
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        EnemyIndex = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[EnemyIndex];
        enemyPrefab = Instantiate(enemyPrefab, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        enemyPrefab.transform.parent = gameObject.transform;
        count ++;
        totalcount++;
        }return;

   }
    public  void OnEnable()
    {
        //StartCoroutine(SpawnCoroutine());
        InvokeRepeating("SpawnEnemy", 2f,2f);
    }

    public void Update()
    {
        Enemys.SetText(count.ToString());
        //if(count < enemyAmoundMax && spawning == true)
       // {
             
            
        //}
        if(totalcount == 20)
        {
            spawning = false;
              //CancelInvoke();
        }

    	if(count == 0)
        {
            
        }



     
     }

   
    
}
