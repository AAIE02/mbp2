using UnityEngine;
using UnityEngine.UI;

public class COIN : MonoBehaviour
{
    public int CoinValue = 1;
    [SerializeField] private AudioClip Coin;

    public enum Type
    {
        Coin
    }

    public Type type;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            Collect(other.gameObject);
        }
    }

    private void Collect(GameObject player)
    {
        GameManager.Instance.AddCoin();
        SoundManager.Instance.PlaySound(Coin);
        ScoreManager.instance.ChangeScore(CoinValue);
        Destroy(gameObject);
    }

}
