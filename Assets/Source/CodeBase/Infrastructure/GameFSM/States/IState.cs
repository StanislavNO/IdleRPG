namespace Assets.Source.CodeBase
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Update();
    }
}