namespace EX3_DesignAStack
{
    public class OwnStack
    {
        public List<object> StackList { get; set; }

        public OwnStack()
        {
            StackList = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj != null)
                StackList.Add(obj);
            else
                throw new InvalidOperationException("Null object");
        }

        public object Pop()
        {
            if (StackList.Count != 0)
            {
                var obj = StackList[StackList.Count - 1];
                StackList.RemoveAt(StackList.Count - 1);
                return obj;
            }
            else
            {
                throw new InvalidOperationException("The stack is empty");
            }
        }

        public void Clear()
        {
            StackList.Clear();
        }
    }
}
