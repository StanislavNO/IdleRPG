using Unity.VisualScripting;

namespace Assets.Source.CodeBase
{
    public class Game : IProjectContainer
    {
        private readonly GameStateMachine _stateMachine;
        private readonly StateFactory _stateFactory;
        private readonly ICoroutineRunner _runner;
        private readonly SceneSwitcher _sceneSwitcher;

        public Game(ICoroutineRunner runner)
        {
            _runner = runner;

            _sceneSwitcher = new SceneSwitcher(_runner);
            _stateMachine = new GameStateMachine();
            _stateFactory = new StateFactory(_sceneSwitcher, _stateMachine, this);

            _stateMachine.AddStates(_stateFactory.Create());
            _stateMachine.GoWork();
        }

        public SceneContainer SceneContainer { get; private set; }

        public void InitContainer(SceneContainer container) => SceneContainer = container;

        public void Update() => _stateMachine.Update();
    }
}