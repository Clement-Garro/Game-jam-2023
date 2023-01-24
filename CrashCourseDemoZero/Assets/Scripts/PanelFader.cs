using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PanelFader : MonoBehaviour
{
    private bool mFaded = false;
    public float duration = 1.0f;

    public void Fade()
    {
        var canvasGroup = GetComponent<CanvasGroup>();
        StartCoroutine(DoFade(canvasGroup, canvasGroup.alpha, mFaded ? 1 : 0));
        mFaded = !mFaded;
    }
    
    public IEnumerator DoFade(CanvasGroup canvasGroup, float start, float end)
    {
        float counter = 0f;
        while (counter < duration)
        {
            counter += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, end, counter / duration);

            yield return null;
        }
    }
}
