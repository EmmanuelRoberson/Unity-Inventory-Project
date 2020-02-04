using System;

[System.Serializable]
public struct TransferableObject
{
    private UnityEngine.Object objectData;
    private object objData;
    
    public UnityEngine.Object ObjectData
    {
        get => objectData;
        set => objectData = value;
    }

    public object ObjData { get; set; }
}
