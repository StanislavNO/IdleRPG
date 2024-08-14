using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class SceneContainer : MonoBehaviour , IDispose
    {
        [SerializeField] private View _view;

        private HeroModel _hero;

        public void Init(Mediator mediator, HeroModel hero)
        {
            View = mediator;
            _hero = hero;
        }

        private void OnDisable()
        {
            Disposed?.Invoke();
        }

        public event Action Disposed;


        [field: SerializeField]
        public HeroConfig HeroConfig { get; private set; }

        public Mediator View { get; private set; }
    }
}
