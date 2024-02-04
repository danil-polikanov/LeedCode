/*public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
*/
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode l3 = new ListNode();
        ListNode temp = l3;
        bool discharge = false;
        while (l1 != null || l2 != null)
        {
            if (l1 == null)
            {
                temp.val = l2.val + Convert.ToInt32(discharge);
                l2 = l2.next;
            }
            else if (l2 == null)
            {
                temp.val = l1.val + Convert.ToInt32(discharge);
                l1 = l1.next;
            }
            else if (l1.val + l2.val + Convert.ToInt32(discharge) >= 10)
            {
                temp.val = l1.val + l2.val + Convert.ToInt32(discharge);
                l1 = l1.next;
                l2 = l2.next;
            }
            else
            {
                temp.val = l1.val + l2.val + Convert.ToInt32(discharge);
                l1 = l1.next;
                l2 = l2.next;
            }
            discharge = false;
            if (temp.val >= 10)
            {
                temp.val = temp.val % 10;
                discharge = true;
            }


            if (l1 == null && l2 == null && discharge == true)
            {
                temp.next = new ListNode(1);
            }
            else if(l1 == null && l2 == null && discharge == false)
            {
                break;
            }
            else
            {
                temp.next = new ListNode();
            }
            temp = temp.next;
        }
        return l3;
    }
}