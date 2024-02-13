using UnityEngine;

public class PlayerEffectHandler : MonoBehaviour
{
    [SerializeField] private GameObject jumpEffectPrefab;

    public void PlayJumpEffect()
    {
        GameObject jumpEffect = Instantiate(jumpEffectPrefab, transform.position, transform.rotation);
        Destroy(jumpEffect, 2f);
    }
}
