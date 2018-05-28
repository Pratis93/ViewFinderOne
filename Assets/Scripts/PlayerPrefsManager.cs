using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {


    [Header("Player Definition")]
    const string PLAYER_ACCURACY_SHOT = "my_shot";
    const string PLAYER_ACCURACY_HIT = "my_hit";

    /// <summary>
    /// Set count of Player Shot
    /// </summary>
    /// <param name="shotCount"></param>
    public static void SetPlayerShot(float shotCount)
    {
        PlayerPrefs.SetFloat(PLAYER_ACCURACY_SHOT, shotCount);
    }

    /// <summary>
    /// Get count of Player Shot
    /// </summary>
    /// <param name="shotCount"></param>
    public static float GetPlayerShot()
    {
        return PlayerPrefs.GetFloat(PLAYER_ACCURACY_SHOT);
    }

    /// <summary>
    /// Set count of Player hit
    /// </summary>
    /// <param name="shotCount"></param>
    public static void SetPlayerHit(float hitCount)
    {
        PlayerPrefs.SetFloat(PLAYER_ACCURACY_HIT, hitCount);
    }

    /// <summary>
    /// Get count of Player hit
    /// </summary>
    /// <param name="shotCount"></param>
    public static float GetPlayerHit()
    {
        return PlayerPrefs.GetFloat(PLAYER_ACCURACY_HIT);
    }
}
