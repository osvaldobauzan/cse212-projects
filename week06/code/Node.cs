public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
    if (value < Data) {
        if (Left == null) {
            Left = new Node(value);
        } else {
            Left.Insert(value);
        }
    } else if (value > Data) {
        if (Right == null) {
            Right = new Node(value);
        } else {
            Right.Insert(value);
        }
    }
    // Do nothing if the value is equal (no duplicates allowed).
}


    public bool Contains(int value) {
    if (value == Data) {
        return true;
    } else if (value < Data && Left != null) {
        return Left.Contains(value);
    } else if (value > Data && Right != null) {
        return Right.Contains(value);
    }
    return false;
}


    public int GetHeight() {
    int leftHeight = (Left != null) ? Left.GetHeight() : 0;
    int rightHeight = (Right != null) ? Right.GetHeight() : 0;

    return 1 + Math.Max(leftHeight, rightHeight);
}

}