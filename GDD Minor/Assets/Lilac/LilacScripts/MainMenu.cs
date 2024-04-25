using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public string gameSceneName = "Svetlin-testing-safe-game";

    
    public DataPersistenceManager dataPersistenceManager;


    private void Start() 
    {
        //if (!DataPersistenceManager.instance.HasGameData()) 
        //{
        //    continueGameButton.interactable = false;
        //}
    }

    public void LoadGameScene()
    {
        
        SceneManager.LoadSceneAsync("Svetlin-testing-safe-game");
        
    }

    public void NewGame()
    {
        
        //DisableMenuButtons();
        // create a new game - which will initialize our game data
        DataPersistenceManager.instance.NewGame();
        // load the gameplay scene - which will in turn save the game because of
        // OnSceneUnloaded() in the DataPersistenceManager
        SceneManager.LoadSceneAsync("Svetlin-testing-safe-game");
        
    }
}
