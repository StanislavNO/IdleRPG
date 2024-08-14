using UnityEngine.UI;
using UnityEngine;
using System;

namespace Assets.Source.CodeBase
{
    public class Mediator
    {
        private readonly Button _switchWeapon;
        private readonly Button _heal;

        public Mediator() 
        {

        }

        //public event Action 

        public void StartIdle()
        {
            _heal.enabled = true;
        }

        public void StopIdle() 
        {
            _heal.enabled = false;
        }

        public void StartAttack(float time)
        {

        }

        public void StopAttack() 
        {

        }

        public void StartCooldown()
        {

        }

        public void TickCooldown(float time)
        {

        }

        public void StopCooldown() 
        {
            
        }
    }
}