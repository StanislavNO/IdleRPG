using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class SceneContainer : MonoBehaviour
    {
        [SerializeField] private View _view;

        private HeroModel _hero;

        [field: SerializeField] public HeroConfig HeroConfig { get; private set; }
        public Mediator View {  get; private set; }

        private void Awake()
        {
            View = new();
        }
    }
}
