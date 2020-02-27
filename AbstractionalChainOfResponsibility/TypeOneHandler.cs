namespace AbstractionalChainOfResponsibility
{
    class TypeOneHandler : AbstractHandler
    {
        public override Result Handle(IProblem problem)
        {
            if (problem is TypeOneProblem)
            {
                return new Result() { Description = $"TypeOneHandler managed {problem.GetDescription()}" };
            }
            else
            {
                return base.Handle(problem);
            }
        }
    }

}
