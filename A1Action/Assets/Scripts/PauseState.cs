using UnityEngine;
using UnityEngine.Events;

public class PauseState : MonoBehaviour, IState
{
    [SerializeField] private Canvas pauseMenu;

    public UnityEvent OnEnterState;
    public UnityEvent OnExitState;
    public UnityEvent OnUpdateState;

    public void EnterState()
    {
        Debug.Log("Entering Pause State");

        Time.timeScale = 0f;
        pauseMenu.enabled = true;

        OnEnterState?.Invoke();
    }

    public void ExitState()
    {
        Debug.Log("Exiting Pause State");

        Time.timeScale = 1f;
        pauseMenu.enabled = false;

        OnExitState?.Invoke();
    }

    public void UpdateState()
    {
        OnUpdateState?.Invoke();

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E key pressed: Resuming Game");

           
            var stateManager = ServiceLocator.instance.GetService<StateManager>();
            stateManager.ChangeState(stateManager.gamePlayState);
        }
    }
}
