namespace W8_assignment_template.Interfaces;

public interface ICharacter
{
    IRoom CurrentRoom { get; }
    int HP { get; set; }
    int Level { get; set; }
    string Name { get; set; }
    string Type { get; set; }

    void Attack(ICharacter target);
    void Move(IRoom room);
    void Move(string? direction);
}
