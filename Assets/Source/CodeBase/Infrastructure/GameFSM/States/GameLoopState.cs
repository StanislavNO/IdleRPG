namespace Assets.Source.CodeBase
{
    public abstract class GameLoopState : IState
    {
        private readonly IReadOnlyContainer _sceneContainer;

        protected GameLoopState(IReadOnlyContainer sceneContainer)
        {
            _sceneContainer = sceneContainer;
        }

        protected IReadOnlyContainer Data => _sceneContainer;

        public virtual void Enter()
        {
        }

        public virtual void Exit()
        {
        }

        public virtual void Update()
        {
        }
    }
}
