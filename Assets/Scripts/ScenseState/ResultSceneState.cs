using UnityEngine;
using UnityEngine.InputSystem;

public class ResultSceneState : IState
{
    private ScenManager _sceneManager;
    public void Enter()
    {
        Debug.Log($"{GetType().Name}‚ªn‚Ü‚é");

        _sceneManager = GameObject.FindAnyObjectByType<ScenManager>();
    }
    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _sceneManager.ChangeScene(new TitleSceneState());
        }
    }
    public void Exit()
    {
        Debug.Log($"{GetType().Name}‚ªI‚í‚é");
    }
}
