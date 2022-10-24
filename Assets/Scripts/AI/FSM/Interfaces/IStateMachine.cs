using AI.FSM.Interfaces.State;

namespace AI.FSM.Interfaces
{
    public interface IStateMachine
    {
        public void ChangeState(IState nextState);
        public void ExecuteFixedUpdate();
    }
}