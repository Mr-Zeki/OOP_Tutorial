using UnityEngine;

public class MoveCommand : ICommand
{
    private PlayerMovement _player;
    private Vector3 _movement;

    public MoveCommand(PlayerMovement player, Vector3 movement)
    {
        this._player = player;
        this._movement = movement;
    }

    public void Execute()
    {
        _player.HandleMovement(_movement);
    }

    public void Undo()
    {
        _player.HandleMovement(-_movement);
    }
}