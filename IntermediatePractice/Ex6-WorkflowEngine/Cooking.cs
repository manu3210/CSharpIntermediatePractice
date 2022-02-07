namespace Ex6_WorkflowEngine
{
    public class Cooking : IActivity
    {
        public string Description { get; set; }

        public string Execute()
        {
            return "Doing cooking activity: " + Description;
        }
    }
}
