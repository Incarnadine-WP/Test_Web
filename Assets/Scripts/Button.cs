using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private LoadSprites loadPanel;

    private int animIndex = Animator.StringToHash("anim");
    private bool on;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        StartGame();
    }

    private void StartGame()
    {
        if (!on)
        {
            on = true;
            animator.SetBool(animIndex, true);
            loadPanel.load();
            Debug.Log("Click");
        }
    }
}
