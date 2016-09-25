URL : https://www.hackerrank.com/challenges/insert-a-node-into-a-sorted-doubly-linked-list?h_r=next-challenge&h_v=zen

/*
    Insert Node in a doubly sorted linked list 
    After each insertion, the list should be sorted
   Node is defined as
   struct Node
   {
     int data;
     Node *next;
     Node *prev;
   }
*/
Node* SortedInsert(Node *head,int data)  
{  
    // Complete this function  
   // Do not write the main method.   
    Node *cur = new Node();  
    cur->data = data;  
    cur->next = cur->prev = NULL;  
    if(head == NULL)  
        return cur;  
    Node *pos = head;  
    while(pos != NULL && pos->data <= data)  
        pos = pos->next;  
    if(pos == NULL)  
    {  
        Node *tail = head;  
        while(tail->next != NULL)  
            tail = tail->next;  
        tail->next = cur;  
        cur->prev = tail;  
        return head;  
    }  
    Node *pre = pos->prev;  
    if(pre == NULL)  
    {  
        cur->next = head;  
        head->prev = cur;  
        return cur;  
    }  
    pre->next = cur;  
    cur->prev = pre;  
    cur->next = pos;  
    pos->prev = cur;  
    return head;  
}