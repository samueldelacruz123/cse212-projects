using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue and test to see if the added values are added to
    // the queue. And also, to chech and see if the queue prioritizes the item with
    // higher priority value.
    // Expected Result: Munaks, Luna, Chrislyn, Sam
    // Defect(s) Found: 
    public void TestPriorityQueue_EnqueueAndDequeueHighestPriority()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Sam", 1);
        priorityQueue.Enqueue("Chrislyn", 2);
        priorityQueue.Enqueue("Luna", 3);
        priorityQueue.Enqueue("Munaks", 4);

        Assert.AreEqual("Munaks", priorityQueue.Dequeue());
        Assert.AreEqual("Luna", priorityQueue.Dequeue());
        Assert.AreEqual("Chrislyn", priorityQueue.Dequeue());
        Assert.AreEqual("Sam", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Create a queue with two string names with the same priority value
    // and see if the function will add the first one on the line.
    // Expected Result: Sam, Chrislyn, Luna
    // Defect(s) Found: 
    public void TestPriorityQueue_SameHighestPriorityFIFO()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Sam",3);
        priorityQueue.Enqueue("Chrislyn", 3);
        priorityQueue.Enqueue("Luna", 2);

        Assert.AreEqual("Sam", priorityQueue.Dequeue());
        Assert.AreEqual("Chrislyn", priorityQueue.Dequeue());
        Assert.AreEqual("Luna", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: To check and see if an error would occur if there are no items in
    // the queue
    // Expected Result: Error with error
    // Defect(s) Found: 

    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );

        Assert.AreEqual("The queue is empty.", exception.Message);
    }

    // Add more test cases as needed below.
}