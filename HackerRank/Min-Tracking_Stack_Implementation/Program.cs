//Q9
//Test Results : All available test cases passed
//Chat GPT was used to implement the function getMin in O(1)
class Result
{
    /*
     * Complete the 'processCouponStackOperations' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts STRING_ARRAY operations as parameter.
     */
    public static List<int> processCouponStackOperations(List<string> operations)
    {
        Stack s = new Stack();
        List<int> result = new List<int>();

        foreach (string operation in operations)
        {
            if (operation == "getMin")
            { result.Add(s.getMin()); }
            else if (operation == "pop")
            { s.pop(); }
            else if (operation == "top")
            { result.Add(s.top()); }
            else if (operation.Contains("push"))
            {
                string[] op_origins = operation.Split(" ");
                s.push(int.Parse(op_origins[1]));
            }
        }
        return result;
    }
    public class Stack
    {
        public List<int> minStack { get; set; }
        public List<int> mainStack { get; set; }

        public Stack()
        {
            minStack = new List<int>();
            mainStack = new List<int>();
        }
        public int top()
        {
            int value = mainStack[mainStack.Count - 1];
            return value;
        }

        public void pop()
        {
            int value = mainStack[mainStack.Count - 1];
            mainStack.RemoveAt(mainStack.Count - 1);

            if (minStack[minStack.Count() - 1] == value)
            {
                minStack.RemoveAt(minStack.Count() - 1);
            }
        }

        public void push(int value)
        {
            mainStack.Add(value);
            if (minStack.Count == 0 || minStack[minStack.Count() - 1] >= value)
            {
                minStack.Add(value);
            }
        }

        public int getMin()
        {
            return minStack[minStack.Count() - 1];
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int operationsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> operations = new List<string>();

        for (int i = 0; i < operationsCount; i++)
        {
            string operationsItem = Console.ReadLine();
            operations.Add(operationsItem);
        }

        List<int> result = Result.processCouponStackOperations(operations);

        Console.WriteLine(String.Join("\n", result));
    }
}