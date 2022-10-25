using System;

namespace AI.FSM.Interfaces.State
{
    public interface ITransition
    {
        /// <summary>
        /// List of actions in the Transition.
        /// </summary>
        /// <returns></returns>
        public IActions Actions { get; }

        public Action OnTransitionEnds { get; set; }
    }
}