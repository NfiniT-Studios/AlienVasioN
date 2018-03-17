using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Base class for all interactable objects in the game.</summary>
public abstract class BaseObject : MonoBehaviour, IIdentifiable {
    [Space(10)]
    [Header("Base Object Properties")]
    [Tooltip("Object's Name")]
    [SerializeField]
    private string objectName;
    [Tooltip("Object's Description")]
    [SerializeField]
    private string objectDescription;





    public string ObjectName
    {
        get
        {
            return objectName;
        }

        set
        {
            objectName = value;
        }
    }
    public string ObjectDescription
    {
        get
        {
            return objectDescription;
        }

        set
        {
            objectDescription = value;
        }
    }





    virtual public void Awake()
    {
        
    }
    abstract public void RemoveIdentity();
    abstract public void RevealIdentity();
}
