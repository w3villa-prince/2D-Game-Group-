using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scroll_spped = 0.3f;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        scroll();
    }

    private void scroll()
    {
        Vector2 vector2 = meshRenderer.sharedMaterial.GetTextureOffset("_MainTex");
        vector2.y += Time.deltaTime * scroll_spped;
        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", vector2);
    }
}
