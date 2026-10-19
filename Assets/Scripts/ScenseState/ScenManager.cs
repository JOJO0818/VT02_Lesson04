using UnityEngine;

public class ScenManager : MonoBehaviour
{
    private IState _currentSceneState; //現在実行中の画面

    void Start()
    {
        _currentSceneState = new TitleSceneState();
        _currentSceneState.Enter();
    }

    void Update()
    {
        _currentSceneState.Execute();     //画面を実行中
    }

    public void ChangeScene(IState nextScene)
    {
        //現在の画面処理を終了
        _currentSceneState.Exit();
        //現在の画面を、次の画面で上書き
        _currentSceneState = nextScene;
        //新しい画面を開始させる
        _currentSceneState.Enter();
    }
}
