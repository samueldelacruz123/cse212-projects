public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN FOR MultiplesOf(number, length)
        // 
        // Goal:
        // Create and return an array that contains multiples of the starting number.
        //
        // Example:
        // MultiplesOf(4, 5) should return:
        // {4, 8, 12, 16, 20}
        //
        // Steps:
        // 1. Create an array that accepts double number with a size equal to length.
        //
        // 2. Use a loop starting at index 0 until length - 1. Each loop will
        //    calculate one multiple. In the loop, the 
        //    first multiple should be number * 1, then number * 2, 
        //    until number * length.
        //
        // 3. Store each calculated multiple into the array
        //    at the current index.
        //
        // 4. Then after that loop finishes, it should return the completed array.
        double[] result = new double[length];
        
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN for RotateListRight()
        // 
        // Goal:]
        // Move the values in the list to the right by the given amount.
        //
        // Example:
        // Current list: {1, 2, 3, 4, 5, 6, 7, 8, 9}
        // Amount: 4
        // Rotated list: {6, 7, 8, 9, 1, 2, 3, 4, 5}
        //
        // Steps:
        // 1. Locate the position where the list should be split.
        //    The split position should be data.Count - amount.
        //
        // 2. Create a list that contains the values from the split
        //    position to the end. These values will move to the
        //    front of the list.
        //
        // 3. Create another list that contains the values from the
        //    beginning to the split position. These values will move
        //    to the back of the list.
        //
        // 4. Then, the original list should be cleared or rebuilt.
        //
        // 5. Add the values after the split position to the first
        //    part of the list and then the values before the split
        //    position.
        //
        // 6. The new list is now rotated to the right by the
        //    specified amount.

        int split = data.Count - amount;

        List<int> right = data.GetRange(split, amount);
        List<int> left = data.GetRange(0, split);

        data.Clear();

        data.AddRange(right);
        data.AddRange(left);
    }
}
