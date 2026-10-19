using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneState : IState
{
    // ===メンバー変数=== //
    private ScenManager _sceneManager;
    public void Enter()
    {
        Debug.Log($"{GetType().Name}が始まる");

        _sceneManager = GameObject.FindAnyObjectByType<ScenManager>();
    }
    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _sceneManager.ChangeScene(new GameSceneState());
        }
    }
    public void Exit()
    {
        Debug.Log($"{GetType().Name}が終わる");
    }
}
