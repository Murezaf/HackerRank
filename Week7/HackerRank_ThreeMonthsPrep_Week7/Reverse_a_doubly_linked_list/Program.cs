class DoublyLinkedListNode
{
    public int data;
    public DoublyLinkedListNode next;
    public DoublyLinkedListNode prev;

    public DoublyLinkedListNode(int nodeData)
    {
        this.data = nodeData;
        this.next = null;
        this.prev = null;
    }
}

class DoublyLinkedList
{
    public DoublyLinkedListNode head;
    public DoublyLinkedListNode tail;

    public DoublyLinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void InsertNode(int nodeData)
    {
        DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

        if (this.head == null)
        {
            this.head = node;
        }
        else
        {
            this.tail.next = node;
            node.prev = this.tail;
        }

        this.tail = node;
    }
}

class Result
{
    public static DoublyLinkedListNode reverse(DoublyLinkedListNode llist)
    {
        DoublyLinkedListNode current = llist; DoublyLinkedListNode temp = null;

        if (llist == null || llist.next == null)
        {
            return llist;
        }

        while (current != null)
        {
            temp = current.prev;
            current.prev = current.next;
            current.next = temp;

            current = current.prev;
        }

        return temp.prev;
    }

    //public static DoublyLinkedListNode reverse(DoublyLinkedListNode llist)
    //{
    //    DoublyLinkedListNode first = null; DoublyLinkedListNode second = llist; DoublyLinkedListNode third = llist.next;

    //    if (llist == null || llist.next == null)
    //    {
    //        return llist;
    //    }

    //    while (second != null)
    //    {
    //        second.next = first;
    //        second.prev = third;

    //        first = second;
    //        second = third;
            //if (third != null)
            //{
            //    third = third.next;
            //}
    //    }

    //    return first;
    //}
}

public class Solutuion
{
    static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            DoublyLinkedList llist = new DoublyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            DoublyLinkedListNode llist1 = Result.reverse(llist.head);

            PrintDoublyLinkedList(llist1, " ", textWriter);
            textWriter.WriteLine();
        }

        textWriter.Flush();
        textWriter.Close();
    }
}