namespace Assets.Source.CodeBase
{
    public abstract class GameLoopState : IState
    {
        private readonly IReadOnlyContainer _sceneContainer;

        private Timer _timer;

        protected GameLoopState(IReadOnlyContainer sceneContainer)
        {
            _sceneContainer = sceneContainer;
        }

        protected IReadOnlyContainer Data => _sceneContainer;

        public virtual void Enter() 
        {
            SetTimer();
        }

        public virtual void Exit() { }

        public virtual void Update()
        {
            _timer.Tick();
            _sceneContainer.SceneContainer.View.ChangeTime(_timer.Time);
        }

        protected abstract void SetTimer();
    }
}
