using AI.FSM.Interfaces.State;
using UnityEngine;

namespace AI.FSM.Actions
{
    public class ScalePulse : IActionFixedUpdate
    {
        private readonly GameObject _gameObject;

        public ScalePulse(GameObject gameObject) => _gameObject = gameObject;

        public void Run() => _gameObject.transform.localScale *= Mathf.Sin(Time.fixedDeltaTime);
    }
}