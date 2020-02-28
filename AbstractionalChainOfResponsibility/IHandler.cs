namespace AbstractionalChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        IHandleResult Handle(IProblem problem);
    }

}
