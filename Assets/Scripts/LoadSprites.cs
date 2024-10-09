using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadSprites : MonoBehaviour
{
    public SpriteRenderer[] SpriteRenderer;
    public AssetReferenceAtlasedSprite[] AddressableSprite;

    private bool isLoaded;

    public void load()
    {
        if (!isLoaded)
        {
            isLoaded = true;
            for (int i = 0; i < SpriteRenderer.Length; i++)
            {
                StartCoroutine(LoadSprite(SpriteRenderer[i], i));
            }
        }
    }

    private IEnumerator LoadSprite(SpriteRenderer spriteRenderer, int number)
    {
        var task = AddressableSprite[number].LoadAssetAsync<Sprite>();
        yield return task;
        spriteRenderer.sprite = task.Result;
    }
}
