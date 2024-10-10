namespace W8_assignment_template.Interfaces;

public interface IRoom
{
    List<ICharacter> Characters { get; }
    string Description { get; }
    IRoom? East { get; set; }
    string Name { get; }

    IRoom? North { get; set; }
    IRoom? South { get; set; }
    IRoom? West { get; set; }

    void Enter();
    void AddCharacter(ICharacter character);
    void RemoveCharacter(ICharacter character);
}
