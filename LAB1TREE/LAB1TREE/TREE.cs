namespace LAB1TREE
{
    public class Tree
    {
        private int Value;
        int count = 0;
        Tree[] objects = new Tree[3];


        public void SetValue(int value)
        {
            this.Value = value;
        }
        public int GetValue()
        {
            return Value;
        }

        public void SetLink(Tree obj)
        {
            if (count == objects.Length)
            {
                Array.Resize(ref objects, objects.Length + 3);
            }
            objects[count] = obj;
            count++;
        }

        public Tree(int value)
        {
            this.Value = value;
        }
        public Tree(int value, Tree obj)
        {
            Value = value;
            SetLink(obj);
        }
        public List<int> ToList()
        {
            List<int> list = new List<int>();
            list.Add(Value);
            for (int i = 0; i < count; i++)
            {
                list.AddRange(objects[i].ToList());
            }
            return list;
        }
        public int[] GetChildArray()
        {
            return ToList().ToArray();
        }

    }
}
