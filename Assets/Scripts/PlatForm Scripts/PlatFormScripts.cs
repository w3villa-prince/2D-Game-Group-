using System.Collections;
using UnityEngine;

public class PlatFormScripts : MonoBehaviour
{
    public float moveSpeed = .009f;
    public float boundY = 6;
    public bool movingPlatformLeft, movingPlatformRight, isBreakable, isSpike, isPlatform;

    private Animator anim;
    public bool gamePlay = true;

    private void Awake()
    {
        if (isBreakable)
        {
            Debug.Log("Animation Calling....");
            anim = GetComponent<Animator>();
        }
    }

    private void Update()
    {
        StartCoroutine(Co_Move());
    }

    private IEnumerator Co_Move()
    {
        while (gamePlay)
        {
            Debug.Log("Move Method Calling");
            Move();
            yield return null;
        }
    }

    private void Move()
    {
        Debug.Log("Move Method call");
        Vector2 temp = transform.position;
        temp.y += moveSpeed * Time.deltaTime;
        transform.position = temp;
        if (temp.y >= boundY)
        {
            Destroy(gameObject);
            gamePlay = false;
        }
    }
}
