public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data)
        {
            return;
        }
        if (value < Data)
        {
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        if (value < Data)
        {
            return Left?.Contains(value) ?? false;
        }
        else
        {
            return Right?.Contains(value) ?? false;
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (this is null)
        {
            return 0;  
        }
        if (Left is null && Right is null)
        {
            return 1; 
        }
        if (Left is null)
        {
            return 1 + (Right?.GetHeight() ?? 0);
        }
        if (Right is null)
        {
            return 1 + Left.GetHeight();  
        }
        int leftHeight = Left.GetHeight();   
        int rightHeight = Right.GetHeight(); 
        if (leftHeight > rightHeight)
        {
            return 1 + leftHeight;  
        }
        else
        {
            return 1 + rightHeight;  
        }                 
         
    }
}