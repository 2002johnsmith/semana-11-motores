using UnityEngine;
using System.Collections;

public class BurnEffect : MonoBehaviour
{
    public enum BurnType { Fire, Poison }

    public Material burnedMaterial;
    public Material poisonedMaterial;
    private Material originalMaterial;
    private Renderer rend;

    void Awake()
    {
        rend = GetComponent<Renderer>();
        originalMaterial = rend.material;
    }

    public void StartBurnEffect(BurnType type)
    {
        StopAllCoroutines();
        StartCoroutine(BurnRoutine(type));
    }

    IEnumerator BurnRoutine(BurnType type)
    {
        switch (type)
        {
            case BurnType.Fire:
                rend.material = burnedMaterial;
                break;
            case BurnType.Poison:
                rend.material = poisonedMaterial;
                break;
        }

        yield return new WaitForSeconds(3f);
        rend.material = originalMaterial;
    }
}
