//Q10
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
     * Complete the 'removeKthNodeFromEnd' function below.
     *
     * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
     * The function accepts following parameters:
     *  1. INTEGER_SINGLY_LINKED_LIST head
     *  2. INTEGER k
     */

    public static SinglyLinkedListNode removeKthNodeFromEnd(SinglyLinkedListNode head, int k)
    {
        SinglyLinkedListNode current = head;
        int length = 1;
        while (current.next != null)
        {
            length++;
            current = current.next;
        }

        if (length == 0)
        { return null; }
        int index = length - k - 1;
        current = head;

        if (index < 0)
        { return head; }
        if (index == 0)
        {
            return head.next;
        }
        for (int i = 0; i < index - 1; i++)
        {
            current = current.next;
        }
        if (current.next.next != null)
        {
            current.next = current.next.next;
        }
        else { current.next = null; }
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

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        SinglyLinkedListNode result = Result.removeKthNodeFromEnd(head.head, k);

        SinglyLinkedListPrintHelepr.PrintList(result, "\n");
        Console.WriteLine();
    }
}
