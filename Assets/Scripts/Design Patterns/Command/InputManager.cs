using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button upButton;
    [SerializeField] private Button downButton;
    [SerializeField] private Button leftButton;
    [SerializeField] private Button rightButton;
    [SerializeField] private Button undoButton;
    [SerializeField] private Button redoButton;
    
    [Header("References")]
    [SerializeField] private PlayerMovement _player;
    
    private _commandInvoker _commandInvoker;

    private void Awake()
    {
        _commandInvoker = new _commandInvoker();
        
        upButton.onClick.AddListener(OnUpButtonClick);
        downButton.onClick.AddListener(OnDownButtonClick);
        leftButton.onClick.AddListener(OnLeftButtonClick);
        rightButton.onClick.AddListener(OnRightButtonClick);
        undoButton.onClick.AddListener(OnUndoButtonClick);
        redoButton.onClick.AddListener(OnRedoButtonClick);
    }

    private void RunPlayerCommand(PlayerMovement player, Vector3 movement)
    {
        if (player == null) { return; }
        ICommand command = new MoveCommand(player,movement);
        _commandInvoker.ExecuteCommand(command);
    }

    private void OnLeftButtonClick()
    {
        RunPlayerCommand(_player,Vector3.right);
    }
    private void OnRightButtonClick()
    {
        RunPlayerCommand(_player,Vector3.left);
    }
    private void OnUpButtonClick()
    {
        RunPlayerCommand(_player,Vector3.back);
    }
    private void OnDownButtonClick()
    {
        RunPlayerCommand(_player,Vector3.forward);
    }

    private void OnUndoButtonClick()
    {
        _commandInvoker.UndoCommand();
    }

    private void OnRedoButtonClick()
    {
        _commandInvoker.RedoCommand();
    }
}