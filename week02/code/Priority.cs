using System.Reflection.Metadata;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();

        // Test Cases

        // Test 1
        // Scenario: try to dequeue before adding items to the priority queue.
        // Expected Result: The queue is empty.
        Console.WriteLine("Test 1");

        var check = priorityQueue.Dequeue();

        // Defect(s) Found: 

        Console.WriteLine("---------");


        // Test 2
        // Scenario: Test to make sure that the enqueue function is adding properly by appending the queue.
        // In addition test to make sure it is removing the items properly from queue, by selecting the one with the highest priority near the front.
        // Expected Results:
        // [Bobby (Pri:2), Ammon (Pri:1), James (Pri:4), Alicia (Pri:3), Jessica (Pri:4)]
        // James, Jessica, Alicia, Bobby, Ammon
        // []

        Console.WriteLine("Test 2");

        priorityQueue.Enqueue("Bobby", 2);
        priorityQueue.Enqueue("Ammon", 1);
        priorityQueue.Enqueue("James", 4);
        priorityQueue.Enqueue("Alicia", 3);
        priorityQueue.Enqueue("Jessica", 4);

        Console.WriteLine(priorityQueue);
        for(int i = 0; i < 5; i++){
            var result = priorityQueue.Dequeue();
            Console.WriteLine(result);
        }
        Console.WriteLine(priorityQueue);

        // Defect(s) Found:
            // The program was not removing the dequeued item. As well as doing a greater than or equal
            // check on the priority causing the last item with the same priority to return instead of the first.
            // In addition the class was not checking until the end of the queue for priority, but instead was checking until the second to last.
            //

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}