using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.CodeBase
{
    public interface IContainer : IReadOnlyContainer
    {
        public void InitContainer(SceneContainer container);
    }

    public interface IReadOnlyContainer
    {
        SceneContainer SceneContainer { get; }
    }
}
