using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.CodeBase
{
    public class CooldownState : GameLoopState
    {
        public CooldownState(IStateSwitcher stateSwitcher, IReadOnlyContainer sceneContainer) : base(stateSwitcher, sceneContainer)
        {
        }

        protected override void Visit() =>
            StateSwitcher.SwitchState<CooldownState>();
    }
}
