namespace _01_CircularQueue{
    public class MyCircularQueue {

    private int[] queue {get;set;}
    private int head {get;set;}
    private int tail {get;set;}
    private int nb {get;set;}
    private int k {get;set;}
    
    /** Initialize your data structure here. Set the size of the queue to be k. */
    public MyCircularQueue(int k) {
        head = 0;
        tail = 0;
        nb = 0;
        this.k = k;
        queue = new int[k];
        
        for(int i = 0; i<k;i++){
            queue[i] = -1;
        }
            
    }
    
    /** Insert an element into the circular queue. Return true if the operation is successful. */
    public bool EnQueue(int value) {
        if(nb >= k)
            return false;
       
       
        
        
        queue[tail] = value;
        
        if(tail == k-1)
            tail = 0;
        else
            tail++;
         
        
        nb++;
        
        return true;
    }
    
    /** Delete an element from the circular queue. Return true if the operation is successful. */
    public bool DeQueue() {
        if(nb == 0)
            return false;
        
        queue[head] = -1;
        nb--;
        
        if(head == k-1)
            head=0;
        else
            head++;
        
        return true;
    }
    
    /** Get the front item from the queue. */
    public int Front() {
        return queue[head];
    }
    
    /** Get the last item from the queue. */
    public int Rear() {
        if(tail == 0)
            return queue[k-1];
        else
            return queue[tail-1];
    }
    
    /** Checks whether the circular queue is empty or not. */
    public bool IsEmpty() {
        return nb == 0;
    }
    
    /** Checks whether the circular queue is full or not. */
    public bool IsFull() {
        return nb == k;
    }
}
}
