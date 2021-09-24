using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSyncerColor : AdioSyncer
{
    public Color[] beatColors;
    public Color restColor;

    private int randomIndx;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private IEnumerator MoveToColor(Color _target)
    {
        Color _curr = image.color;
        Color _initial = _curr;
        float _timer = 0;

        while (_curr != _target)
        {
            _curr = Color.Lerp(_initial, _target, _timer / timeToBeat);
            _timer += Time.deltaTime;

            image.color = _curr;

            yield return null;
        }

        beating = false;
    }

    private Color RandomColor()
    {
        if (beatColors == null || beatColors.Length == 0) return Color.white;
        randomIndx = Random.Range(0, beatColors.Length);
        return beatColors[randomIndx];
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (beating) return;

        image.color = Color.Lerp(image.color, restColor, restSmoothTime * Time.deltaTime);
    }

    public override void OnBeat()
    {
        base.OnBeat();

        Color _c = RandomColor();

        StopCoroutine("MoveToColor");
        StartCoroutine("MoveToColor", _c);
    }

}
