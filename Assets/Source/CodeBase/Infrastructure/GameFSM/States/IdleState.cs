using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.CodeBase
{
    public class IdleState : GameLoopState
    {
        public IdleState(IStateSwitcher stateSwitcher, IReadOnlyContainer sceneContainer) : base(stateSwitcher, sceneContainer)
        {
        }

        public override void Enter()
        {
            base.Enter();

            View.StartIdle();
        }

        public override void Exit()
        {
            base.Exit();

            View.StopIdle();
        }

        protected override void Visit() =>
            StateSwitcher.SwitchState<IdleState>();
    }
}
