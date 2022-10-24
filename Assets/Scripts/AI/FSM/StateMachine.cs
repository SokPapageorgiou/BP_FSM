using System.Collections.Generic;
using AI.FSM.Interfaces;
using AI.FSM.Interfaces.State;

namespace AI.FSM
{
    public class StateMachine : IStateMachine
    {
        private IState _currentState;
        private readonly List<IActionFixedUpdate> _mainActions = new ();
        private readonly List<IActionFixedUpdate> _exitEnterActions = new();

        public StateMachine(IState startState) => _currentState = startState;
            
        public void ChangeState(IState nextState)
        {
            AddToActionList(_exitEnterActions, _currentState.ExitActions());
            
            _currentState = nextState;
            AddToActionList(_exitEnterActions, _currentState.EntryActions());
            
            _mainActions.Clear();
            AddToActionList(_mainActions, _currentState.Transition().Actions());
            _currentState.Transition().OnTransitionEnds += SwitchToMainActions;
        }

        public void ExecuteFixedUpdate()
        {
            if (_exitEnterActions.Count > 0)
            {
                RunActions(_exitEnterActions);
                _exitEnterActions.Clear();
            }
            
            RunActions(_mainActions);
        }

        private void RunActions(List<IActionFixedUpdate> list)
        {
            foreach (var action in list) action.Run();
        }

        private void AddToActionList(List<IActionFixedUpdate> list, IActions actionsToAdd)
        {
            foreach (var action in actionsToAdd.List())
                list.Add(action);
        }

        private void SwitchToMainActions()
        {
            _mainActions.Clear();
            AddToActionList(_mainActions, _currentState.Actions());
        }
    }
}