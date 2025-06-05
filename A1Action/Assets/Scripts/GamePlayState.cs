using UnityEngine;
using UnityEngine.Events;

public class GamePlayState : MonoBehaviour, IState
{

    public UnityEvent OnEnterState;

    public UnityEvent OnExitState;

    public UnityEvent OnUpdateState;




    public void EnterState()
    {
        Debug.Log("Entering Gameplay State");
        OnEnterState.Invoke();
    }

    public void ExitState()
    {
        Debug.Log("Entering Gameplay State");
        OnExitState.Invoke();
    }

    public void UpdateState()
    {
        Debug.Log("Updating Gameplay State");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        
    }

    public void PauseGame()
    {
        var stateManager = ServiceLocator.instance.GetService<StateManager>();
        stateManager.ChangeState(stateManager.pauseState);
    }
}
