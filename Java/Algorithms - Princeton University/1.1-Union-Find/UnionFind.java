class QuickFindUF{
    int [] id;
    public QuickFindUF(int N){
        id = new int[N];
        for(int i = 0; i < id.length; i++) id[i] = i;
    }
    public boolean connected(int a, int b){
        return id[a] == id[b];
    }
    public void union(int a, int b){
        if(!connected(a, b)){
            int aid = id[a];
            int bid = id[b];
            for(int i = 0; i < id.length; i++){
                if(id[i] == id[aid]) id[i] = id[bid];
            }
        }else return;
    }
}
class QuickUnionUF{  
    int [] id;
    public QuickUnionUF(int N){
        id = new int[N];
        for(int i = 0; i < id.length; i++) id[i] = i;
    }
    public boolean connected(int a, int b){
        return root(a) == root(b);
    }
    public int root(int a){
        while(a != id[a]) a = id[a];
        return a;
    }
    public void union(int a, int b){
        int i = root(a);
        int j = root(b);
        id[i] = j;
    }
    /*
    Improving Quick Union.
    1) Weighted Quick Union.
    wt[] is the weight array
    if(wt[i] < wt[j]){
        id[root(i)] = root(j);
        wt[j]+=wt[i];
    }else{
        id[root(j)] = root(i);
        wt[i]+=wt[j];
    }

    2) Path Compresser.
    while(i != id[i]){
        id[i] = id[id[i]];
        i = id[i];
    }
    return i;
    */
}
public class UnionFind{
    public static void main(String[] args) {
        QuickUnionUF q = new QuickUnionUF(5);
        q.union(0, 2);
        q.union(0, 1);
        q.union(3, 2);
        for(int i : q.id){
            System.out.print(i + "  ");   // 2 1 1 1 4 
            System.out.println();
        }

        QuickFindUF f = new QuickFindUF(5);
        f.union(2, 3);
        f.union(0, 1);
        f.union(0, 4);
        for(int i : f.id){
            System.out.print(i + "  ");    // 4 4 3 3 4 
        }
    }
}