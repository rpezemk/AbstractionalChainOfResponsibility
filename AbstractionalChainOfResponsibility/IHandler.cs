namespace AbstractionalChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        Result Handle(IProblem problem);
    }

}
