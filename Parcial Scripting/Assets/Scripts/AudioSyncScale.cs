using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncScale : AdioSyncer
{

    public Vector3 beatScale;
    public Vector3 restScale;

    private IEnumerator MoveToScale(Vector3 target)
    {
        Vector3 curr = transform.localScale;
        Vector3 initial = curr;
        float timer = 0;

        while (curr != target)
        {
            curr = Vector3.Lerp(initial, target, timer / timeToBeat);
            timer += Time.deltaTime;

            transform.localScale = curr;

            yield return null;
        }

        beating = false;
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (beating) return;

        transform.localScale = Vector3.Lerp(transform.localScale, restScale, restSmoothTime * Time.deltaTime);
    }

    public override void OnBeat()
    {
        base.OnBeat();

        StopCoroutine("MoveToScale");
        StartCoroutine("MoveToScale", beatScale);
    }

}
