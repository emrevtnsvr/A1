
using UnityEngine;
using UnityEngine.Events;


public class MenuState : MonoBehaviour, IState
{

    public UnityEvent OnEnterState;

    public UnityEvent OnExitState;

    public UnityEvent OnUpdateState;

    [SerializeField] public Canvas mainMenu;

    public void EnterState()
    {
        Debug.Log("Entering Menu State");

        mainMenu.enabled = true;
        Time.timeScale = 0f;

        OnEnterState?.Invoke();
    }
    public void ExitState()
    {
        Debug.Log("Exiting Menu State");

        mainMenu.enabled = false;
        Time.timeScale = 1f;


        OnExitState?.Invoke();
    }

    public void UpdateState()
    {
        Debug.Log("Updating Menu State");
        OnUpdateState.Invoke();
    }

    public void StartGame()
    {
        var stateManager = ServiceLocator.instance.GetService<StateManager>();
        stateManager.ChangeState(stateManager.gamePlayState);

    }
}
