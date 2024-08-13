
namespace Assets.Source.CodeBase
{
    public interface IStateSwitcher
    {
        public void SwitchState<T> () where T : IState;
    }
}