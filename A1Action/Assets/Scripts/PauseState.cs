using UnityEngine;
using UnityEngine.Events;

public class PauseState : MonoBehaviour, IState
{
    [SerializeField] private StateManager gameStateManager;

    public UnityEvent OnEnterState;

    public UnityEvent OnExitState;

    public UnityEvent OnUpdateState;

    [SerializeField] public Canvas pauseMenu;
    public void EnterState()
    {
        Debug.Log("Entering Pause State");

        pauseMenu.enabled = true;

        Time.timeScale = 0f;

        OnEnterState.Invoke();
    }

    public void ExitState()
    {
        Debug.Log("Entering Pause State");

        Time.timeScale = 1f;

        OnExitState.Invoke();
    }

    public void UpdateState()
    {
        Debug.Log("Entering Pause State" );
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Debug.Log("E key pressed: Resuming Game");
            gameStateManager.ChangeState(gameStateManager.gamePlayState);
            pauseMenu.enabled = false;

        }


        OnUpdateState.Invoke();
    }

    
}
