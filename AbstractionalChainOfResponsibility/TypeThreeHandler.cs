namespace AbstractionalChainOfResponsibility
{
    class TypeThreeHandler : AbstractHandler
    {
        public override Result Handle(IProblem problem)
        {
            if (problem is TypeThreeProblem)
            {
                return new Result() { Description = $"TypeThreeHandler managed {problem.GetDescription()}" };
            }
            else
            {
                return base.Handle(problem);
            }
        }
    }

}
