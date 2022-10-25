using System.Collections.Generic;

namespace AI.FSM.Interfaces.State
{
    public interface IActions
    {
        public List<IActionFixedUpdate> List { get; }
    }
}