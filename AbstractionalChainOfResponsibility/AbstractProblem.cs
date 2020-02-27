namespace AbstractionalChainOfResponsibility
{
    class AbstractProblem : IProblem
    {
        public string Description;
        public virtual string GetDescription()
        {
            return this.Description;
        }
    }

}
