using System.Collections.Generic;
using System.Linq;

public class ModifyEmoticon
{
    private readonly List<ICommand> _commands;
    private ICommand _command;

    public ModifyEmoticon()
    {
        _commands = new List<ICommand>();
    }

    public void UndoActions()
    {
        foreach (var command in Enumerable.Reverse(_commands))
        {
            command.UndoAction();
        }
    }

    public void SetCommand(ICommand command) => _command = command;

    public void Invoke()
    {
        _commands.Add(_command);
        _command.ExecuteAction();
    }
}