namespace AbstractionalChainOfResponsibility
{
    class TypeTwoHandler : AbstractHandler
    {
        public override IHandleResult Handle(IProblem problem)
        {
            if (problem is TypeTwoProblem)
            {
                return new Result() { Description = $"TypeTwoHandler managed {problem.GetDescription()}" };
            }
            else
            {
                return base.Handle(problem);
            }
        }
    }

}
