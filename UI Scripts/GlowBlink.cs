using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class GlowBlink : MonoBehaviour 
{	
    [Range(0,30f)]
    public float Padding = 0f;

    void Update()
    {
        RectTransform r = transform as RectTransform;
        r.offsetMax = new Vector2(-Padding, -Padding);
        r.offsetMin = new Vector2(Padding, Padding);
    }
}
