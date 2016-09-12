#https://www.hackerrank.com/challenges/detect-whether-a-linked-list-contains-a-cycle/submissions/code/27725279

"""
Detect a cycle in a linked list. Note that the head pointer may be 'None' if the list is empty.

A Node is defined as: 
 
    class Node(object):
        def __init__(self, data = None, next_node = None):
            self.data = data
            self.next = next_node
"""


def has_cycle(head):
    if head is None or head.next is None:
        return False;
    
    fast = head;
    slow = head;
    
    while fast != head and fast != slow:
        if fast is None or slow is None or fast.next is None:
            return False;
        
        fast = fast.next.next
        slow = slow.next
        
    return True;