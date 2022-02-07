using System.Text;

namespace Ex6_WorkflowEngine
{
    public class Workflow : IWorkFlow
    {
        private IList<IActivity> _list;
        public Workflow()
        {
            _list = new List<IActivity>();
        }

        public string Run()
        {
            var sb = new StringBuilder();

            foreach (var activity in _list)
            {
                sb.Append(activity.Execute());
                sb.Append("\nDone!\n");
            }

            return sb.ToString();
        }

        public void AddToList(IActivity act)
        {
            _list.Add(act);
        }
    }
}
