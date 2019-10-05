namespace RestaurantApp.Utilities
{
    public class ComboBoxWithProps
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public ComboBoxWithProps(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
