using W8_assignment_template.Interfaces;

namespace W8_assignment_template.Models.Characters;

public class Player : CharacterBase
{
    public string Equipment { get; set; }
    public int Gold { get; set; }

    public Player()
    {
    }

    public Player(string name, string type, int level, int hp, string equipment, int gold, IRoom startingRoom) : base(name, type, level, hp, startingRoom)
    {
        Equipment = equipment;
        Gold = gold;
    }

    public override void UniqueBehavior()
    {
        throw new NotImplementedException();
    }
}
