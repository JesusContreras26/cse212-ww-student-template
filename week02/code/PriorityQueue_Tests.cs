using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue and add information to it in order to test the priority queue function  
    // Expected Result: It should return the last value insert as the first value dequeue with the highest priority
    // Defect(s) Found: It wasn't dequeue the value from the queue at the end because the removeAt method was never called
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        // Add items to the priority queue
        priorityQueue.Enqueue("a", 2);
        priorityQueue.Enqueue("b", 1);
        priorityQueue.Enqueue("c", 3);
        
        // Dequeue items and check the order
        Assert.AreEqual("c", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Create a queue and add information to it in order to test the priority queue function but there will 
    // be several functions with the same priority to see if the last one inserted with the same priority is removed first
    // Expected Result: It should return the value with the highest priority and if there is one with the same priority it should
    // return the last one inserted
    // Defect(s) Found: it wasn't working dequeueing the last inserted with same priority because it was a -1 that make it return 
    // one before the last with highest priority
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // Add items to the priority queue
        priorityQueue.Enqueue("x", 5);
        priorityQueue.Enqueue("y", 6);
        priorityQueue.Enqueue("z", 6);
        priorityQueue.Enqueue("a", 6);
        // Dequeue items and check the order
        Assert.AreEqual("a", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}