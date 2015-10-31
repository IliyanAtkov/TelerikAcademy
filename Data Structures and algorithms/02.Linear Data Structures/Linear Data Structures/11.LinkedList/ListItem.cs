namespace LinkedList
{
    public class ListItem<T>
    {
        public ListItem(T value)
        {
            this.Value = value;
        }

        public ListItem(T value, ListItem<T> previousItem)
            :this(value)
        {
            previousItem.NextItem = this;
        }


        public T Value { get; set; }

        public ListItem<T> NextItem { get; set; }
    }
}