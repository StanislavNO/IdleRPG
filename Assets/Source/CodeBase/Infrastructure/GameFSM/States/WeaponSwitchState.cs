using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class WeaponSwitchState : GameLoopState
    {
        private const float Delay = 2f;

        private float _time;

        public WeaponSwitchState(IStateSwitcher stateSwitcher, IReadOnlyContainer sceneContainer) : base(stateSwitcher, sceneContainer)
        {
            _time = Delay;
        }

        protected override void Visit() =>
            StateSwitcher.SwitchState<WeaponSwitchState>();

        private void Tick()
        {
            if (_time > 0)
                _time -= Time.deltaTime;

            if (_time < 0)
            {
                _time = Delay;
                GoBackState();
            }
        }
    }
}
