using System;

class ObjectDispenser : IDistributable
{
    public ObjectStorage toStorage;
    public ObjectStorage fromStorage;
    
    public virtual void DistributeAllTo()
    {
        toStorage.Collect(fromStorage.hoardedObjects.ToArray());
        fromStorage.hoardedObjects.Clear();
    }
}