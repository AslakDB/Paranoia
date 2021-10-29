using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using static UnityEngine.Time;
using Image = UnityEngine.UIElements.Image;

public class FadeIn : MonoBehaviour
{
    public bool mFaded = false;
    

    public float duration = 0.4f;


    public void Fade()
    {
        var canvGroup = GetComponent<CanvasGroup>();

        StartCoroutine(DoFade(canvGroup, canvGroup.alpha, mFaded ? 1 : 0));

        mFaded = !mFaded;
    }

    public IEnumerator DoFade(CanvasGroup canvGroup, float start, float end)
    {
        float countrer = 0f;

        while (countrer < duration)
        {
            canvGroup.alpha = Mathf.Lerp(start, end, countrer / duration);

            yield return null;
        }
    }
}

