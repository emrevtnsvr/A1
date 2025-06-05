using UnityEngine;
using UnityEngine.Events;


public class GameOverState : MonoBehaviour, IState
{

    [SerializeField] private Canvas gameOverCanvas;

    public UnityEvent OnEnterState;

    public UnityEvent OnExitState;

    public UnityEvent OnUpdateState;
    public void EnterState()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0f;
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
