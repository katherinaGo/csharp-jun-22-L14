namespace Lesson14;

public class UniqueItem
{
    private int _id;
    private int test;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public int Test
    {
        get => test;
        set => test = value;
    }

    public UniqueItem(int id)
    {
        id++;
        Id = id;
        Test = Id;
    }

    public UniqueItem()
    {
        _id++;
    }
}