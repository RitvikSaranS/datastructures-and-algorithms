//Implementation using linked list
class Stack{
    Node head = null;
    int size = 0;
    class Node{
        Node link;
        int data;
    }
    public Stack(int data){
        head = new Node();
        head.data = data;
        size++;
    }
    public void isEmpty(Node head){
        return head == null;
    }
    public void push(int data){
        Node tmp = new Node();
        tmp.data = data;
        tmp.link = head;
        head = tmp;
        size++;
    }
    public void pop(){
        if(size > 0){
            int tmp = head.data;
            head = head.link;
            size--;
            System.out.println(tmp);
        }
    }
}
public class Main
{
	public static void main(String[] args) {
		Stack i = new Stack(6);
		i.push(4);
		i.push(7);
		i.push(8);
		i.pop();
		i.pop();
	}
}


//Another better but similar implementation using linked list
class Stack{
    private int size = 0;
    private Node head = null;
    private class Node{
        int value;
        Node next = null;
        public Node(int value){
            this.value = value;
        }
    }
    public void push(int value){
        Node node = new Node(value);
        node.next = head;
        head = node;
        size++;
    }
    public void pop(){
        if(!isEmpty()){
            int popped = head.value;
            head = head.next;
            size--;
            System.out.println(popped);
        }
        else System.out.println("The stack is empty!!");
    }
    public boolean isEmpty() {
        return head == null;
    }
    public int size(){
        return size;
    }
}
public class Main
{
	public static void main(String[] args) {
		Stack s = new Stack();
		s.push(2);
		s.push(3);
		s.push(7);
		System.out.println(s.size());
		s.pop();
		s.pop();
		s.pop();
		s.pop();
	}
}

//Implementation using Arrays
