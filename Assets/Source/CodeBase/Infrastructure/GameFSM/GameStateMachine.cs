using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Source.CodeBase
{
    public class GameStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currentState;

        public void Update()
        {
            _currentState?.Update();
        }

        public void GoWork()
        {
            _currentState = _states[0];
            _currentState.Enter();
        }

        public void AddStates(List<IState> states)
        {
            if (states is null)
                throw new ArgumentNullException(nameof(states));

            _states = states;
        }

        public void SwitchState<T>() where T : IState
        {
            IState state = _states.FirstOrDefault(state => state is T);

            _currentState.Exit();
            _currentState = state;
            _currentState?.Enter();
        }
    }
}