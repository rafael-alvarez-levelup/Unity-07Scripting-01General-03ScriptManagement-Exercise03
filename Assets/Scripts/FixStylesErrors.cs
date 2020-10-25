using UnityEngine;
using Game.Scripts;

public class FixStylesErrors : MonoBehaviour
{
    #region Variables

    public DataClass customData;

    internal string customName = "fixStylesErrors";

    protected SampleScript sampleScript;

    private Collider myCustomCollider;

    #endregion

    #region Initialization

    private void Awake()
    {
        myCustomCollider = GetComponent<Collider>();
        sampleScript = GetComponent<SampleScript>();
    }

    private void Start()
    {
        customData = new DataClass();
        customData.sample = 2;
    }

    #endregion

    #region Update Methods

    private void FixedUpdate()
    {
        // FixedUpdate logic
    }

    private void Update()
    {
        // Update logic
    }

    private void LateUpdate()
    {
        //LateUpdate logic
    }

    #endregion

    #region Interface

    public string SampleParamsFunction(string value)
    {
        return $"Hello, {value}";
    }

    #endregion

    #region Member Methods

    private void SimpleFunction()
    {
        // SimpleFunction logic
    }

    #endregion
}