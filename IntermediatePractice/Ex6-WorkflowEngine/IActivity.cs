namespace Ex6_WorkflowEngine
{
    public interface IActivity
    {
        string Description { get; set; }
        string Execute();
    }
}
