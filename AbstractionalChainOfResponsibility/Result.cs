namespace AbstractionalChainOfResponsibility
{
    public class Result : IHandleResult
    {
        public string Description;
        public virtual string GetDescription()
        {
            return this.Description;
        }
        public virtual void SetDescription(string description)
        {
            this.Description = description;
        }
    }
}
