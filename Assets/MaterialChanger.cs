using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    [SerializeField] float changePerTime;
    [SerializeField] List<Material> mats;

    float curTime;
    int curMatIdx;
    MeshRenderer renderer;

    void Start()
    {
        if (renderer == null)
            renderer = GetComponent<MeshRenderer>();

        renderer.material = mats[0];
    }

    private void Update()
    {
        curTime += Time.deltaTime;

        if (curTime >= changePerTime)
        {
            curTime = 0;

            if (renderer == null)
                renderer = GetComponent<MeshRenderer>();

            renderer.material = mats[curMatIdx];
            curMatIdx++;

            if (curMatIdx == mats.Count)
                curMatIdx = 0;
        }
    }
}
