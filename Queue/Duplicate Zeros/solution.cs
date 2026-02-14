 public class Solution {
    public void DuplicateZeros(int[] arr) {
        Queue<int> queue = new Queue<int>();
        // Solving this question feels bit harder, but logic is so simple if you use Queues
        // enqueue all traversed element bit by bit. If its zero, enqueue it twice
        // before enqueuing next element, dequeue the peek element to the current bit.
        queue.Enqueue(arr[0]); 
        if(arr[0] == 0) queue.Enqueue(0);

        for(int i = 0; i < arr.Length; i++){
            arr[i] = queue.Dequeue();
            if((i + 1) < arr.Length){
                if(arr[i + 1] == 0){
                    queue.Enqueue(0);
                    queue.Enqueue(0);
                }
                else{
                    queue.Enqueue(arr[i + 1]);
                }
            }
        }
    }
}
