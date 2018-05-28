using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

   public enum  Scenes
    {
        NewGame,
        ViewFinder,
        Win,
        GameOver,
    }

    /// <summary>
    /// Load Scene by Name
    /// </summary>
    /// <param name="scene"></param>
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    /// <summary>
    /// LoadSceneByNumber
    /// </summary>
    /// <param name="scene"></param>
    public void LoadSceneInt(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    /// <summary>
    /// Exit Game
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
  
}
