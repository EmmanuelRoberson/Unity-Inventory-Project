using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

public class TestBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

interface IHoardable
{
    void Collect<T>(params T[] collectedObjects);
}

interface IDistributable
{
    void DistributeByType<T>(params IHoardable[] hoardTypes);
    
    void DistributeAllTo();

    void DistributeBySort(ConditionTypeList conditionTypes);
}

struct TransferableObject
{
    private UnityEngine.Object objectData;
    
    public UnityEngine.Object ObjectData
    {
        get => objectData;
        set => objectData = value;
    }
}

class ObjectStorage<T> : IHoardable
{
    private List<T> hoardedObjects;
    
    public ObjectStorage(params T[] initialObjects)
    {
        hoardedObjects = new List<T>(initialObjects);
    }

    public void Collect<T>(params T[] collectedObject)
    {
        throw new System.NotImplementedException();
    }
}

struct ConditionTypeList
{
    public List<object> conditionalTypes;
}

class ObjectDispenser : IDistributable
{

    void TestFunc()
    {
        
    }

    public void DistributeByType<T>(params IHoardable[] hoardTypes)
    {
        throw new NotImplementedException();
    }

    public void DistributeAllTo()
    {
        throw new NotImplementedException();
    }

    public void DistributeBySort(ConditionTypeList conditionTypes)
    {
        throw new NotImplementedException();
    }

}
