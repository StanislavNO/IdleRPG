using System;

namespace Assets.Source.CodeBase
{
    public interface IDispose
    {
        event Action Disposed;
    }
}