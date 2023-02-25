using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    private Vector3 pontB = Vector3.left;
    public Transform targetTransform;
    public float reverseSpeed = 30f;
    private IEnumerator Start()
    {
        pontB = targetTransform.position;
        Vector3 pointA = transform.position;
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pontB, reverseSpeed));
            yield return StartCoroutine(MoveObject(transform, pontB, pointA, reverseSpeed));
        }
        IEnumerator MoveObject(Transform thisTranform, Vector3 startPos, Vector3 endPos, float time)
        {
            float i = 0;
            float rate = 1.0f / time;
            while (i < 1.0f)
            {
                i += Time.deltaTime*rate;
                thisTranform.position = Vector3.Lerp(startPos, endPos, i);
                yield return null;
            }
        }
    }
}
