using UnityEngine;
using UnityEngine.Events;

public class GameOverState : MonoBehaviour, IState
{
    [SerializeField] private StateManager gameStateManager;

    public UnityEvent OnEnterState;

    public UnityEvent OnExitState;

    public UnityEvent OnUpdateState;
    public void EnterState()
    {
        Debug.Log("Entering GameOver State");
        OnEnterState.Invoke();
    }

    public void ExitState()
    {
        Debug.Log("Entering GameOver State");
        OnExitState.Invoke();
    }

    public void UpdateState()
    {
        Debug.Log("Entering GameOver State");
        OnUpdateState.Invoke();
    }
}
