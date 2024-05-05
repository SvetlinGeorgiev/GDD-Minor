using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void LoadGameScene()
    {
        
        SceneManager.LoadSceneAsync("Svetlin-testing-safe-game");
        
    }

    public void NewGame()
    {
        DataPersistenceManager.instance.NewGame();
        SceneManager.LoadSceneAsync("Svetlin-testing-safe-game");
    }
}
