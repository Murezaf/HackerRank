//Q12
//Test Results : All available test cases passed
class SinglyLinkedListNode
{
    public int data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode(int nodeData)
    {
        this.data = nodeData;
        this.next = null;
    }
}

class SinglyLinkedList
{
    public SinglyLinkedListNode head;
    public SinglyLinkedListNode tail;

    public SinglyLinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void InsertNode(int nodeData)
    {
        SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

        if (this.head == null)
        {
            this.head = node;
        }
        else
        {
            this.tail.next = node;
        }
        this.tail = node;
    }
}

class SinglyLinkedListPrintHelepr
{
    public static void PrintList(SinglyLinkedListNode node, string sep)
    {
        while (node != null)
        {
            Console.Write(node.data);

            node = node.next;

            if (node != null)
            {
                Console.Write(sep);
            }
        }
    }
}

class Result
{
    /*
     * Complete the 'deleteDuplicates' function below.
     *
     * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
     * The function accepts INTEGER_SINGLY_LINKED_LIST head as parameter.
     */

    public static SinglyLinkedListNode deleteDuplicates(SinglyLinkedListNode head)
    {
        if (head == null)
        { return null; }
        SinglyLinkedListNode current = head;
        while (current.next != null)
        {
            if (current.next.data == current.data)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }
        return head;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        SinglyLinkedList head = new SinglyLinkedList();

        int headCount = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 0; i < headCount; i++)
        {
            int headItem = Convert.ToInt32(Console.ReadLine().Trim());
            head.InsertNode(headItem);
        }

        SinglyLinkedListNode result = Result.deleteDuplicates(head.head);

        SinglyLinkedListPrintHelepr.PrintList(result, "\n");
        Console.WriteLine();
    }
}