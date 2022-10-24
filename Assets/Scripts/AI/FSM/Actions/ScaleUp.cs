using AI.FSM.Interfaces.State;
using UnityEngine;

namespace AI.FSM.Actions
{
    public class ScaleUp : IActionFixedUpdate
    {
        private readonly GameObject _gameObject;

        public ScaleUp(GameObject gameObject) => _gameObject = gameObject;
        public void Run() => _gameObject.transform.localScale *= 1.2f;
    }
}