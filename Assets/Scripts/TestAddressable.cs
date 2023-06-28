using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class TestAddressable : MonoBehaviour
{
    public string spriteLabel; // Định danh của sprite
    public SpriteRenderer sprite;

    private void Start()
    {
        LoadSprite();
    }

    private async void LoadSprite()
    {
        AsyncOperationHandle<Sprite> handle = Addressables.LoadAssetAsync<Sprite>(spriteLabel);
        await handle.Task;
        sprite.sprite = handle.Result;

        // Sử dụng sprite tải được ở đây
        // Ví dụ: GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
