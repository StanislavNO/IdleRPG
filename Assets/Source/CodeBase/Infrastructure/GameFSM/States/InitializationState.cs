using System;
using Object = UnityEngine.Object;

namespace Assets.Source.CodeBase
{
    public class InitializationState : IState
    {
        private readonly IStateSwitcher _stateSwitcher;

        private SceneContainer _sceneContainer;
        private IContainer _container;

        public InitializationState(IStateSwitcher stateSwitcher, IContainer container)
        {
            _stateSwitcher = stateSwitcher;
            _container = container;
        }

        public void Enter()
        {
            FindSceneContainer();
            InitSceneContainer();
            _stateSwitcher.SwitchState<StartGameState>();
        }

        public void Exit() { }

        public void Update() { }

        private void InitSceneContainer() =>
            _container.InitContainer(_sceneContainer);

        private void FindSceneContainer()
        {
            _sceneContainer = Object.FindObjectOfType<SceneContainer>();

            if (_sceneContainer is null)
                throw new ArgumentNullException(nameof(_sceneContainer));
        }
    }
}
