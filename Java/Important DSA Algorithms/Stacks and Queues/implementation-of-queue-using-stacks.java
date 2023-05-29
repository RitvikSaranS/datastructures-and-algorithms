import java.util.*;
public class Main
{
	public static void main(String[] args) {
		QueueAdt q = new QueueAdt();
		q.push(5);
		q.push(7);
		q.push(8);
		System.out.println(q.pop());
		System.out.println(q.pop());
		System.out.println(q.size());
		System.out.println(q.peek());
		System.out.println(q.pop());
	}
}
class QueueAdt{
    private Stack<Integer> s;
    private int size;
    public QueueAdt(){
        s = new Stack<>();
        size = 0;
    }
    public void push(int a){
        s.push(a);
        size++;
    }
    public int pop(){
        if(size > 0){
            Stack<Integer> temp = new Stack<>();
            while(!s.isEmpty()) temp.push(s.pop());
            int p = temp.pop();
            while(!temp.isEmpty()) s.push(temp.pop());
            size--;
            return p;
        }
        return -999;
    }
    public int size(){
        return size;
    }
    public int peek(){
        if(size > 0){
            Stack<Integer> temp = new Stack<>();
            while(!s.isEmpty()) temp.push(s.pop());
            int p = temp.peek();
            while(!temp.isEmpty()) s.push(temp.pop());
            return p;
        }
        return -999;
    }
}