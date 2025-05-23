using UnityEngine;
using UnityEngine.Events;

public class PauseState : MonoBehaviour, IState
{
    [SerializeField] private StateManager gameStateManager;

    public UnityEvent OnEnterState;

    public UnityEvent OnExitState;

    public UnityEvent OnUpdateState;
    public void EnterState()
    {
        Debug.Log("Entering Pause State");

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
        OnUpdateState.Invoke();
    }

}
