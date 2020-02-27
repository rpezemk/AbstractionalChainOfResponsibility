namespace AbstractionalChainOfResponsibility
{
    public class Result : IHandleResult
    {
        public string Description;
        public string GetDescription()
        {
            return this.Description;
        }
        public void SetDescription(string description)
        {
            this.Description = description;
        }
    }

}
