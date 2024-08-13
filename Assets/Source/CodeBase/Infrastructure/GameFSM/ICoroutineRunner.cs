using System.Collections;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator routine);
        void StopCoroutine(Coroutine routine);
    }
}