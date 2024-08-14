using System.Collections.Generic;

namespace Assets.Source.CodeBase
{
    public class StateFactory : IStateFactory
    {
        private readonly IStateSwitcher _stateSwitcher;
        private readonly SceneSwitcher _sceneSwitcher;
        private readonly IProjectContainer _container;

        public StateFactory(SceneSwitcher sceneSwitcher, IStateSwitcher stateSwitcher, IProjectContainer container)
        {
            _sceneSwitcher = sceneSwitcher;
            _stateSwitcher = stateSwitcher;
            _container = container;
        }

        public List<IState> Create()
        {
            List<IState> states = new List<IState>()
            {
                new SceneLoaderState(_sceneSwitcher, _stateSwitcher),
                new InitializationState(_stateSwitcher, _container),
                new StartGameState(_stateSwitcher,_container)
            };

            return states;
        }
    }
}