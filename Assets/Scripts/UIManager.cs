using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

   [Header("Player stats")]
   public Text life;

    [Header("Level Manager")]
    public LevelManager level;

    // Update is called once per frame
    void Update()
    {
        CheckAndSetStats();
        CheckCountOfEnemy();
    }

    /// <summary>
    /// Check count of enemy. If count of enemy = 0. Player win game. 
    /// </summary>
    void CheckCountOfEnemy()
    {
        if (EnemySpawner.countOfEnemyOnScene <= 0)
        {
            PlayerControler.TurnOnMouse();

            level.LoadSceneInt((int)LevelManager.Scenes.Win);
        }
    }

    /// <summary>
    /// Check and Set player stats on game scene. 
    /// </summary>
    void CheckAndSetStats()
    {
        int lifeInt = PlayerControler.life;
        life.text = "Life: " + lifeInt.ToString();
    }

 
}
