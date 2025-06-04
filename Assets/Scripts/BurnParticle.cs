using UnityEngine;

public class BurnParticle : MonoBehaviour
{
    void OnParticleCollision(GameObject other)
    {
        var burnEffect = other.GetComponent<BurnEffect>();
        if (burnEffect != null)
        {
            string tag = gameObject.tag;

            switch (tag)
            {
                case "FireParticle":
                    burnEffect.StartBurnEffect(BurnEffect.BurnType.Fire);
                    break;
                case "PoisonParticle":
                    burnEffect.StartBurnEffect(BurnEffect.BurnType.Poison);
                    break;
            }
        }
    }
}
