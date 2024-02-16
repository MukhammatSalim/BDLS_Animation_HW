using UnityEngine;
using UnityEngine.UI;

public class CharacterUpdater : MonoBehaviour
{
    private Animator animator;
    public Slider slider;
    private void Start() {
        animator = gameObject.GetComponent<Animator>();
    }
    public void UpdateSpeed(){
        animator.SetFloat("Speed", slider.value);
        Debug.Log("Slider value is " +  slider.value);
    }
}
