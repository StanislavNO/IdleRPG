using System;
using Object = UnityEngine.Object;

namespace Assets.Source.CodeBase
{
    public class InitializationState : IState
    {
        private readonly IStateSwitcher _stateSwitcher;

        private SceneContainer _sceneContainer;
        private IProjectContainer _container;



        public InitializationState(IStateSwitcher stateSwitcher, IProjectContainer container)
        {
            _stateSwitcher = stateSwitcher;
            _container = container;
        }

        public void Enter()
        {
            FindSceneContainer();
            InitProjectContainer();
            InitSceneContainer();

            _stateSwitcher.SwitchState<StartGameState>();
        }

        public void Exit() { }

        public void Update() { }

        private void InitSceneContainer()
        {
            
        }

        private void InitProjectContainer() =>
            _container.InitContainer(_sceneContainer);

        private void FindSceneContainer()
        {
            _sceneContainer = Object.FindObjectOfType<SceneContainer>();

            if (_sceneContainer is null)
                throw new ArgumentNullException(nameof(_sceneContainer));
        }
    }
}
