using UnityEngine;

public class MagnetCollider : MonoBehaviour
{
    [SerializeField]
    private Transform character;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            CoinFollow coinfollow = other.GetComponent<CoinFollow>();
            if (coinfollow != null)
            {
                coinfollow.StartFollowing(character);
            }
        }
    }
}
