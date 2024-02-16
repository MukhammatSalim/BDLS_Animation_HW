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
    }
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
    }
}
