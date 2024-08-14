namespace Assets.Source.CodeBase
{
    public interface IHealth : IDamage, ILive
    {
        public int HealthPoint { get; }
    }

    public interface IDamage
    {
        void TakeDamage(int value);
    }

    public interface ILive
    {
        void AddHealth(int value);
    }
}