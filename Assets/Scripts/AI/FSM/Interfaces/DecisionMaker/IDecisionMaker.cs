using Unity.VisualScripting;

namespace AI.FSM.Interfaces.DecisionMaker
{
    public interface IDecisionMaker
    {
        /// <summary>
        /// Return the State it should be. 
        /// </summary>
        /// <returns></returns>
        public IState Result();
    }    
}

