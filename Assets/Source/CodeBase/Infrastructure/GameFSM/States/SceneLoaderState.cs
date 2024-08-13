using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Source.CodeBase
{
    public class SceneLoaderState : IState
    {
        private readonly SceneSwitcher _sceneSwitcher;
        private readonly IStateSwitcher _stateSwitcher;

        public SceneLoaderState(SceneSwitcher sceneSwitcher, IStateSwitcher stateSwitcher)
        {
            _sceneSwitcher = sceneSwitcher;
            _stateSwitcher = stateSwitcher;
        }

        public void Enter()
        {
            Debug.Log("Enter SceneLoader " + SceneManager.sceneCount);
            _sceneSwitcher.LoadScene(GoToBootstrapScene);
        }

        public void Exit() { }

        public void Update() { }

        private void GoToBootstrapScene() =>
            _stateSwitcher.SwitchState<InitializationState>();
    }
}
