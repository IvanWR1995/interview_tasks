namespace Interview
{
     class FifthTask
    {
        static public ListNode CreateClosedList(int sizeList)
        {
            ListNode head = new ListNode();
            ListNode cursor = head;
            for (int i = 0; i < sizeList; i++)
            {
                cursor.next = new ListNode();
                cursor = cursor.next;
            }
            cursor.next = head;
            return head;
        }

        static public ListNode CreateNotClosedList(int sizeList)
        {
            ListNode head = new ListNode();
            ListNode cursor = head;
            for (int i = 0; i < sizeList; i++)
            {
                cursor.next = new ListNode();
                cursor = cursor.next;
            }
          
            return head;
        }
        static public bool Run(ListNode head)
        {
            if (head is null)
                return false;

            var cursor = head;
            var hashSet = new HashSet<ListNode>();
            while (cursor != null)
            {
                if (!hashSet.Add(cursor))
                    return true;
                cursor = cursor.next;
            }

            return false;
        }

    }
}
