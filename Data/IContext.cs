using W8_assignment_template.Models.Characters;

namespace W8_assignment_template.Data;

public interface IContext
{
    // READ
    List<CharacterBase> Characters { get; set; }

    // CREATE
    void AddCharacter(CharacterBase character);

    // DELETE
    void DeleteCharacter(string characterName);

    // UPDATE
    void UpdateCharacter(CharacterBase character);
}
