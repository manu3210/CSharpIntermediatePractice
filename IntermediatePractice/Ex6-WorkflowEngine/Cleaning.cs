namespace Ex6_WorkflowEngine
{
    public class Cleaning : IActivity
    {
        public string Description { get; set; }
        public string Execute()
        {
            return "Doing cleaning activity: " + Description;
        }
    }
}
