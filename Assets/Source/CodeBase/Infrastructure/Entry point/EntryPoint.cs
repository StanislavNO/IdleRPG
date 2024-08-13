using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class EntryPoint : MonoBehaviour, ICoroutineRunner
    {
        private Game _game;

        private void Awake()
        {
            _game = new(this);

            DontDestroyOnLoad(this);
        }

        private void Update()
        {
            _game.Update();
        }
    }
}