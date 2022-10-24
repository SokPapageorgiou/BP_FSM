using AI.FSM.Interfaces.State;
using UnityEngine;

namespace AI.FSM.Actions
{
    public class ColorWhite : IActionFixedUpdate
    {
        private readonly Material _material;

        public ColorWhite(Material material) => _material = material;

        public void Run() => _material.color *= 1.2f;
    }
}