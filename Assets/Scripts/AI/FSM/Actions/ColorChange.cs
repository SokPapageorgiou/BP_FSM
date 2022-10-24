using AI.FSM.Interfaces.State;
using UnityEngine;

namespace AI.FSM.Actions
{
    public class ColorChange : IActionFixedUpdate
    {
        private readonly Material _material;

        public ColorChange(Material material) => _material = material;
        
        public void Run()
        {
            float red = Mathf.Cos(Time.fixedDeltaTime);
            float green = Mathf.Sin(Time.deltaTime);
            Color color = new Color(red, green, 1, 1);

            _material.color = color;
        }
    }
}