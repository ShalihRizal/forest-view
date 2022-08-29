using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class AtlasLoader : MonoBehaviour
{
    [SerializeField] private SpriteAtlas atlasmobillejen;

    [SerializeField] private string filename;

    private void Start()
    {
        GetComponent<Image>().sprite = atlasmobillejen.GetSprite(filename);
    }
}
