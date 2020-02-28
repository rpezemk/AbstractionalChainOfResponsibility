namespace AbstractionalChainOfResponsibility
{
    class TypeOneHandler : AbstractHandler
    {
        public override IHandleResult Handle(IProblem problem)
        {
            if (problem is TypeOneProblem)
            {
                return new ResultTypeOne() { Description = $"TypeOneHandler managed {problem.GetDescription()}" };
            }
            else
            {
                return base.Handle(problem);
            }
        }
    }

}
