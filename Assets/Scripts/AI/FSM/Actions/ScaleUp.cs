using AI.FSM.Interfaces.State;
using UnityEngine;

namespace AI.FSM.Actions
{
    public class ScaleUp : IActionFixedUpdate
    {
        private readonly GameObject _gameObject;
        private bool IsUpScale { get; set; }

        public ScaleUp(GameObject gameObject) => _gameObject = gameObject;
      
        public void Run()
        {
            if (IsUpScale) _gameObject.transform.localScale *= 1.2f;
            else _gameObject.transform.localScale /= 1.2f;
        }
    }
}