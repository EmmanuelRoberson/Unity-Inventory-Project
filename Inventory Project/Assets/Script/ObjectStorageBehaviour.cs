using System.Collections.Generic;

class ObjectStorage : IHoardable
{
    
    public List<TransferableObject> hoardedObjects;
    
    public ObjectStorage(params TransferableObject[] initialObjects)
    {
        hoardedObjects = new List<TransferableObject>(initialObjects);
    }

    public virtual void Collect(params TransferableObject[] objects)
    {
        foreach (var obj in objects)
        {
            hoardedObjects.Add(obj);
        }
    }

    public object UniqueValue { get; set; }
}
