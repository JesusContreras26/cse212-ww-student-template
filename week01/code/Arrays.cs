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
        // 1. I created an array of type doubles with the size of the legth parameter.
        double[] result = new double[length];
        // 2. I used a loop to iterate from the variable i to length -1.
        for (int i = 0; i < length; i++)
        {   
            // 3. In each iteration, multiply the number by i + 1 and assign it to the result array at index i.
            result[i] = number * (i + 1);
        }
        // 4. Return the result of the array.
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
        // 1. I created a variable called dataSize and assign it the value of the length of the list of the data 
        // that I am getting from the parameter of the fuction.
        int dataSize = data.Count;
        // 2. I created a variable called rotateAmount and assign it the value of the amount given by the user % size.
        int rotateAmount = amount % dataSize;
        // 3. I Created a variable called dataToAdd and assign it the value of data.GetRange(dataSize - rotateAmount, rotateAmount).
        List<int> dataToAdd = data.GetRange(dataSize - rotateAmount, rotateAmount);
        // 4. I removed the last rotateAmount elements from data using data.RemoveRange(dataSize - rotateAmount, rotateAmount).
        data.RemoveRange(dataSize - rotateAmount, rotateAmount);
        // 5. I inserted the elements from dataToAdd variable at the beginning of data using the method data.InsertRange(0, temp).
        data.InsertRange(0, dataToAdd);
    }
}
