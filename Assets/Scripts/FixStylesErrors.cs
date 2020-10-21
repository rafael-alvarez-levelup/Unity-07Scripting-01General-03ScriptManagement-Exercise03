using Game.Scripts;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class FixStylesErrors : MonoBehaviour
{

    private Collider myCustomCollider;    

    public DataClass customData;

    private void FixedUpdate()
    {

    }

    public string SampleParamsFunction(string value)
    {
        return $"Hello, {value}";
    }

    private void LateUpdate()
    {
        sampleScript = GetComponent<SampleScript>();
    }

    protected SampleScript sampleScript;

    private void Start()
    {
        customData = new DataClass();

        customData.sample = 2;
    }

    private void simpleFunction()
    {

    }

    private void Update()
    {
        myCustomCollider = GetComponent<Collider>();
    }

    internal string customName = "fixStylesErrors";

}

public class DataClass
{
    public int sample;
}
