using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    [Header("player configuration")]
    public Slider sliderNumbers;
    public Text NumbersOfPlayer;
    public static int NumbersOfPlayerToCreate;

    [Header("player stats")]
    public Text accuracy;

    [Header("player new game stats")]
    public static int hitPerRound;
    public static int shotPerRound;


    // Use this for initialization
    void Start ()
    {
        CalculateAndSetAccuracy();
    }

    // Update is called once per frame
    void Update()
    {
        SetNumberOfPlayer();
    }

    /// <summary>
    /// Set Hit and Shot stats
    /// </summary>
    void SetStats()
    {
        hitPerRound = 0;
        shotPerRound = 0;
    }

    /// <summary>
    /// Calculate Accuracy and set label. 
    /// </summary>
    void CalculateAndSetAccuracy()
    {
        float playerHit = PlayerPrefsManager.GetPlayerHit();
        float playerShot = PlayerPrefsManager.GetPlayerShot();

        if (playerShot > 0)
        {
            accuracy.text = (playerHit / playerShot).ToString();
        }
        else
        {
            accuracy.text = "Welcome in Your First Game";
        }
    }

    /// <summary>
    /// Set number of player and set label
    /// </summary>
    void SetNumberOfPlayer()
    {
        int number = (int)sliderNumbers.value;
        NumbersOfPlayerToCreate = number;
        NumbersOfPlayer.text = number.ToString();
        EnemySpawner.countOfEnemyOnScene = number;
    }

    /// <summary>
    /// Player make shoot. Add shoot to statistics.
    /// </summary>
   public static void Shoot()
    {
        float shot = PlayerPrefsManager.GetPlayerShot();
        shot += 1;
        PlayerPrefsManager.SetPlayerShot(shot);

        shotPerRound += 1;
    }

    /// <summary>
    /// Player hit enemy. Add hit to statistics.
    /// </summary>
    public static void Hit()
    {
        float hit = PlayerPrefsManager.GetPlayerHit();
        hit += 1;
        PlayerPrefsManager.SetPlayerHit(hit);

        hitPerRound += 1;
    }
}
