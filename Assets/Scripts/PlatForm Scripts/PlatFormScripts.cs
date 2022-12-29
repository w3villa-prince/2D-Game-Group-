using UnityEngine;

public class PlatFormScripts : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float boundY = 6;
    public bool movingPlatformLeft, movingPlatformRight, isBreakable, isSpike, isPlatform;

    private Animator anim;
    public bool gamePlay = true;

    private void Awake()
    {
        if (isBreakable)
        {
            anim = GetComponent<Animator>();
        }
    }

    private void Update()
    {
        while (gamePlay)
        {
            Move();
        }
    }

    private void Move()
    {
        Vector2 temp = transform.position;
        temp.y += moveSpeed * Time.deltaTime;
        transform.position = temp;
        if (temp.y >= boundY)
        {
            gameObject.SetActive(false);
        }
    }
}
