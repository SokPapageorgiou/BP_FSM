namespace AI.FSM.Interfaces.State
{
    public interface ITransition
    {
        public IActions Actions();
        public bool IsCompleted();
    }
}