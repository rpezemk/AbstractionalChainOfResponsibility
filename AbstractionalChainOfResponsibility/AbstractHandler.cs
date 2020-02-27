namespace AbstractionalChainOfResponsibility
{
    class AbstractHandler : IHandler
    {
        IHandler _nextHandler;
        public virtual IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
        public virtual Result Handle(IProblem problem)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(problem);
            }
            else
            {
                return new Result() { Description = $"Unfortunately, none of handlers managed {problem.GetDescription()}" };
            }
        }
    }

}
