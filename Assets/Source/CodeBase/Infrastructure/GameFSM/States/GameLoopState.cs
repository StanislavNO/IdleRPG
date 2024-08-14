using System;
using Unity.VisualScripting;

namespace Assets.Source.CodeBase
{
    public abstract class GameLoopState : IState
    {
        private readonly IReadOnlyContainer _container;

        private Timer _timer;
        private IReadOnlyContainer sceneContainer;
        private GameLoopState _memoryState;

        protected GameLoopState(IStateSwitcher stateSwitcher, IReadOnlyContainer sceneContainer)
        {
            StateSwitcher = stateSwitcher;
            _container = sceneContainer;
        }

        protected IStateSwitcher StateSwitcher { get; private set; }
        protected IReadOnlyContainer Data => _container;
        protected Mediator View => _container.SceneContainer.View;

        public virtual void Enter()
        {
        }

        public virtual void Exit()
        {
            _memoryState = this;
        }

        public virtual void Update()
        {
        }

        protected void GoBackState() => _memoryState.Visit();

        protected abstract void Visit();
    }
}
