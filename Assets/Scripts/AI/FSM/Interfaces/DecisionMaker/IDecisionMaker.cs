using Unity.VisualScripting;

namespace AI.FSM.Interfaces.DecisionMaker
{
    public interface IDecisionMaker
    {
        /// <summary>
        /// Return the CurrentState. 
        /// </summary>
        /// <returns></returns>
        public IState Result();
    }    
}

