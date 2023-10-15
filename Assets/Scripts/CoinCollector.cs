using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinCollector : MonoBehaviour
{
    public int coinCount;
    public TMP_Text coinCountText;
    public AudioSource coin;
    private void Update()
    {
        coinCountText.text = $"{coinCount}";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coin.Play();
            Destroy(collision.gameObject);
            coinCount++;

        }
    }
}
