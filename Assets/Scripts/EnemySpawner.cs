using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [Header("enemy")]
    public Transform enemyPrefab;
    public static int countOfEnemyOnScene;
    private Transform[] pointsOfRespown;
    //-- Value of CountOfEnemy will change in NewGameScene--//
    public static int CountOfEnemy =10;


    private void Awake()
    {
        CountOfEnemy = PlayerStats.NumbersOfPlayerToCreate;
    }

    // Use this for initialization
    void Start ()
    {
        RandomPositionOfEnemy();
        SpawnEnemy();
    }

    /// <summary>
    /// Random Position Of Enemy. 
    /// </summary>
    void RandomPositionOfEnemy()
    {

        //Lottery numbers and then appointment enemy positon.

        pointsOfRespown = new Transform[CountOfEnemy];
        int[] numbersOfRandom = new int[CountOfEnemy];

        int CountOfNumber = 0;
        int numberRandom;

        bool repeat;

        while(!(CountOfNumber == CountOfEnemy))
        {
            //Lottery numbers
             numberRandom = Random.Range(1, WayPointScript.points.Length);
        
            //number appears in the table? If not add number to table. 
            repeat = false;
            foreach (int number in numbersOfRandom)
            {
                if (number == numberRandom)
                {
                    repeat = true;
                    break;
                }
            }

            if (!repeat)
            {
                    numbersOfRandom[CountOfNumber] = numberRandom;
                    pointsOfRespown[CountOfNumber] = WayPointScript.points[numberRandom];
                    CountOfNumber++;
            }
        }
    }

    /// <summary>
    /// Spawn Enemy on Random Position
    /// </summary>
    void SpawnEnemy()
    {
        foreach(Transform pos in pointsOfRespown)
        {
            var enemy = Instantiate(enemyPrefab, pos.position, pos.rotation);
            enemy.transform.parent = pos;
        }
    }
}
