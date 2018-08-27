namespace le1 {
    public class Person {
    protected string _firstname { get; set; }

    protected string _lastname { get; set; }

    public string FullName { get => $"{_firstname} {_lastname}"; }
    }
}