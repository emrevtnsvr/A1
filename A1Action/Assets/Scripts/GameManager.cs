using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState currentState = GameState.Menu;

    public enum GameState
    {
        Menu,
        LevelSelection
    }

    private void Awake()
    {
       
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
           
        }
    }

    private void Start()
    {
        SetGameState(GameState.Menu);
    }

    public void SetGameState(GameState newState)
    {
        if (currentState == newState)
        {
            currentState = newState;
        }
        switch (currentState)
        {
            case GameState.Menu:
                Debug.Log("MainMenu");
            break;
            case GameState.LevelSelection:
                Debug.Log("LevelSelection");
            break;
        }
    }

    public void LevelSelectionScene()
    {
  
        SceneManager.LoadScene("LevelSelection");
        
    }

    public void ChooseLevelOne()
    {

        SceneManager.LoadScene("Level1");
    }

    public void ChooseLevelTwo()
    {

        SceneManager.LoadScene("Level2");
    }
}
