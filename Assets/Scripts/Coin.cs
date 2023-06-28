using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Coin : MonoBehaviour
{
    [SerializeField] string addressSilverCoin;
    [SerializeField] string addressGoldCoin;
    public string typeCoin;
    [SerializeField] SpriteRenderer spriteCoin;
    AsyncOperationHandle<Sprite> handle;

    private void Start()
    {
        LoadSprite();
    }

    private async void LoadSprite()
    {
        int rand = Random.Range(1, 3);
        if (rand == 1)
        {
            typeCoin = "Silver";
            handle = Addressables.LoadAssetAsync<Sprite>(addressSilverCoin);
        }
        else
        {
            typeCoin = "Gold";
            handle = Addressables.LoadAssetAsync<Sprite>(addressGoldCoin);
        }

        await handle.Task;
        spriteCoin.sprite = handle.Result;

    }
}
