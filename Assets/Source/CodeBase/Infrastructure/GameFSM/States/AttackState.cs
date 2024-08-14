using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.CodeBase
{
    public class AttackState : GameLoopState
    {
        private float _time;

        public AttackState(IStateSwitcher stateSwitcher, IReadOnlyContainer sceneContainer) : base(stateSwitcher, sceneContainer)
        {

        }

        public override void Enter()
        {
            base.Enter();

            View.StartAttack(_time);
        }

        protected override void Visit() =>
            StateSwitcher.SwitchState<AttackState>();
    }
}
