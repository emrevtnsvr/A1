
using UnityEngine;
using UnityEngine.Events;


public class MenuState : MonoBehaviour, IState
{

    public UnityEvent OnEnterState;

    public UnityEvent OnExitState;

    public UnityEvent OnUpdateState;

    [SerializeField] public Canvas mainMenu;

    private void Start()
    {
        mainMenu.enabled = true;
        Time.timeScale = 0f;
    }
    public void EnterState()
    {
        Debug.Log("Entering menu State");
        OnEnterState.Invoke();  
    }
    public void ExitState()
    {
        Debug.Log("Exiting Menu State");
        OnExitState.Invoke();
    }

    public void UpdateState()
    {
        Debug.Log("Updating Menu State");
        OnUpdateState.Invoke();
    }

    public void StartGame()
    {

        mainMenu.enabled = false;
        Time.timeScale = 1f;

        var stateManager = ServiceLocator.instance.GetService<StateManager>();
        stateManager.ChangeState(stateManager.gamePlayState);
    }
}
