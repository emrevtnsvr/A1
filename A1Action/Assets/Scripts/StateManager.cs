using Unity.VisualScripting;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public MenuState menuState;

    public GamePlayState gamePlayState;

    public PauseState pauseState;

    public GameOverState gameOverState;



    private IState _currentState;

    void Start()
    {
        ChangeState(menuState);
    }

    public void ChangeState(IState newState)
    {
        if(_currentState != null)
        {
            _currentState.ExitState();
        }

        _currentState = newState;

        _currentState.EnterState();
    }


  
    void Update()
    {
        if( _currentState != null )
        {
            _currentState.UpdateState();  
        }
    }
}
