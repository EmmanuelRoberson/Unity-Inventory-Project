using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject itemToTransfer;
    private ObjectStorage objStorage;
    private ObjectDispenser objDispenser;

    public TestScript otherScript;

    public Text textObj;

    // Start is called before the first frame update
    void Start()
    {
        objStorage = new ObjectStorage(new TransferableObject
        {
            ObjectData = Instantiate(itemToTransfer)
        })
            {UniqueValue = "TestObject"};
        
        objDispenser = new ObjectDispenser();
    }

    // Update is called once per frame
    void Update()
    {
        textObj.text = "Item Count:" + objStorage.hoardedObjects.Count;
    }

    public void CollectObject()
    {
        objStorage.Collect(new TransferableObject()
        {
            ObjectData = Instantiate(itemToTransfer)
        });
    }

    public void TransferObject()
    {
        otherScript.objStorage.Collect(objStorage.hoardedObjects[0]);
        objStorage.hoardedObjects.RemoveAt(0);
    }
}
