using System.Collections.Generic;

namespace Assets.Source.CodeBase
{
    public interface IStateFactory
    {
        List<IState> Create();
    }
}