using UnityEngine;

public class Wizard : MonoBehaviour
{
    [SerializeField] private AbilityStrategy[] abilities;
    //private const string IS_ATTACKING = "IsAttacking";
    //[SerializeField] private Animator wizardAnimator;

    private void OnEnable()
    {
        SpellsUI.OnSpellButtonPressed += SpellsUI_OnSpellButtonPressed;
    }

    private void OnDisable()
    {
        SpellsUI.OnSpellButtonPressed -= SpellsUI_OnSpellButtonPressed;
    }

    private void SpellsUI_OnSpellButtonPressed(int index)
    {
        abilities[index].UseAbility(this.transform, this.transform.rotation);
        //wizardAnimator.SetTrigger(IS_ATTACKING);
    }
}