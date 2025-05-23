using UnityEngine;
using UnityEngine.Events;

public class GamePlayState : MonoBehaviour, IState
{
    [SerializeField] private StateManager gameStateManager;

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
        Debug.Log("Entering Gameplay State");
        OnUpdateState.Invoke();
    }

    public void PauseGame()
    {
        gameStateManager.ChangeState(gameStateManager.pauseState);
    }
}
