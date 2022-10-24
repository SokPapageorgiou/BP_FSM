namespace AI.FSM.Interfaces.State
{
    public interface IState
    {
        /// <summary>
        /// List of Actions to prepare the State. Entry Actions will run once.
        /// </summary>
        /// <returns></returns>
        public IActions EntryActions();
        
        /// <summary>
        /// Actions will run every single FixedUpdate
        /// </summary>
        /// <returns></returns>
        public IActions Actions();
        
        /// <summary>
        /// List of action to end the State. Exit Actions will run once
        /// </summary>
        /// <returns></returns>
        public IActions ExitActions();
        
        /// <summary>
        /// Transition Actions will run every FixedUpdate until Transition is Completed
        /// </summary>
        /// <returns></returns>
        public ITransition Transition();
    }
}