
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class StartGameState : GameLoopState
    {
        public StartGameState(IStateSwitcher stateSwitcher, IReadOnlyContainer sceneContainer) : base(stateSwitcher, sceneContainer)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Update()
        {
            base.Update();
            StateSwitcher.SwitchState<IdleState>();
        }

        protected override void Visit() =>
            StateSwitcher.SwitchState<StartGameState>();
    }
}