
using UnityEngine;

public interface IState 
{
    void EnterState(PlayerController1 player);
    void ExitState(PlayerController1 player);
    void UpdateState(PlayerController1 player);

}
