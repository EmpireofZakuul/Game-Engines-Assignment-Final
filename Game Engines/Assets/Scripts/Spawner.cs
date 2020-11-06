using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public int spawnRateEnemies = 2;
    public int enemyAmoundMax = 10;
    public TextMeshProUGUI Enemys;
    public static int count = 0;
    public GameObject enemyPrefab;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private int EnemyIndex;


   public void SpawnEnemy()
   {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        EnemyIndex = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[EnemyIndex];
        enemyPrefab = Instantiate(enemyPrefab, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        enemyPrefab.transform.parent = gameObject.transform;

   }
    // Start is called before the first frame update
    void Start()
    {



    }
    public void Update()
    {
        Enemys.SetText(count.ToString());
    }

    void OnEnable()
    {
        StartCoroutine(SpawnCoroutine());
    }

    System.Collections.IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            SpawnEnemy();

            
            count ++;

            //GameObject[] Enemy =
               // GameObject.FindGameObjectsWithTag("Enemy");
            //if (Enemy.Length == enemyAmoundMax)
                if (count == enemyAmoundMax)
                {
                break;
                }
            yield return new WaitForSeconds(1.0f / (float)spawnRateEnemies);
        }
    }

        
    
}
