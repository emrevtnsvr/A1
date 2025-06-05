using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameOverState : MonoBehaviour, IState
{

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
        Debug.Log("Exiting GameOver State");
        OnExitState.Invoke();
    }

    public void UpdateState()
    {
        Debug.Log("Updating GameOver State");
        OnUpdateState.Invoke();

    }





}
