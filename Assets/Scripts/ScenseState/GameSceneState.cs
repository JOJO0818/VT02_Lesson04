using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneState : IState
{
    private ScenManager _sceneManager;

    private GameObject _gameCube;
    public void Enter()
    {
        Debug.Log($"{GetType().Name}Ç™énÇ‹ÇÈ");

        _sceneManager = GameObject.FindAnyObjectByType<ScenManager>();

        _gameCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _sceneManager.ChangeScene(new ResultSceneState());
        }
    }
    public void Exit()
    {
        Debug.Log($"{GetType().Name}Ç™èIÇÌÇÈ");

        GameObject.Destroy(_gameCube);
    }
}
