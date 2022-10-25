using System;
using AI.FSM.Actions;
using AI.FSM.Interfaces.State;
using UnityEngine;

namespace AI.FSM.Transitions
{
    public class ScaleUpUntilOriginalSize : ITransition
    {
        private Vector3 _originalScale;
        private IActionFixedUpdate _scaleUp;
        private IActions _actions;

        public IActions Actions { get; }
        
        public Action OnTransitionEnds { get; set; }
        
        public ScaleUpUntilOriginalSize(GameObject gameObject)
        {
            _originalScale = gameObject.transform.localScale;
            Actions.List.Add(new ScaleUp(gameObject)); 
        }
    }
}