using System;
using System.Collections.Generic;
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

    /// <summary>
    /// Intended to distinguish different instances of IHoardables
    /// </summary>
    Object UniqueValue { get; set; }
}

public interface IDistributable
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

    public virtual void Collect<T>(params T[] collectedObject)
    {
        
    }

    public object UniqueValue { get; set; }
}

struct ConditionTypeList
{
    public List<object> conditionalTypes;
}

class ObjectDispenser : IDistributable
{

    public virtual void DistributeByType<T>(params IHoardable[] hoardTypes)
    {
        throw new NotImplementedException();
    }

    public virtual void DistributeAllTo()
    {
        throw new NotImplementedException();
    }

    public virtual void DistributeBySort(ConditionTypeList conditionTypes)
    {
        throw new NotImplementedException();
    }
    
}

static class ObjectOverseer
{
    private static Dictionary< string, IHoardable> hoardDictionary;
    private static IDistributable distributor;

    public static void ObtainNewHoard(params IHoardable[] hoards)
    {
        hoardDictionary = new Dictionary<string, IHoardable>();
        foreach (var hoard in hoards)
        {
            hoardDictionary.Add(hoard.UniqueValue.ToString(), hoard);
        }
    }

    static ObjectOverseer()
    {
        hoardDictionary = new Dictionary<string, IHoardable>();
    }
}
