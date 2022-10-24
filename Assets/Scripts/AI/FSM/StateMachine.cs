using System.Collections.Generic;
using AI.FSM.Interfaces.State;

namespace AI.FSM
{
    public class StateMachine
    {
        private IState _currentState;
        private readonly Queue<IActionFixedUpdate> _actionsFixedUpdate = new ();

        public StateMachine(IState startState) => _currentState = startState;
        
        public void ChangeState(IState nextState)
        {
            AddToActionsFixedUpdate(_currentState.ExitActions());
            
            _currentState = nextState;
            AddToActionsFixedUpdate(_currentState.EntryActions());
            
            _currentState.Transition().IsCompleted = false;
        }

        public void ExecuteFixedUpdate()
        {
            AddToActionsFixedUpdate(!_currentState.Transition().IsCompleted
                ? _currentState.Transition().Actions()
                : _currentState.Actions());

            while(_actionsFixedUpdate.Count != 0) _actionsFixedUpdate.Dequeue().Run();
        }

        private void AddToActionsFixedUpdate(IActions actionsToAdd)
        {
            foreach (var action in actionsToAdd.List())
                _actionsFixedUpdate.Enqueue(action);
        }
    }
}