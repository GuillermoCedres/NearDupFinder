namespace Domain;

public class Item
{
    public Item(string title)
    {
        if (string.IsNullOrEmpty(title))
        {
            throw new ArgumentException("Title cannot be empty");
        }
    }
}
