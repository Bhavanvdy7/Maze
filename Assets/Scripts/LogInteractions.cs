using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogInteractions : MonoBehaviour
{
    // Start is called before the first frame update
        public void LogHoverEnter (XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Hover Enter by:" + interactor.gameObject.name);
    }

    public void LogHoverExit(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Hover Exit by:" + interactor.gameObject.name);
    }

    public void LogSelect(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Selected by:" + interactor.gameObject.name);
    }

    public void LogDeselect(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Deselected by:" + interactor.gameObject.name);
    }

    public void LogActive(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Activated by:" + interactor.gameObject.name);
    }

    public void LogDeactive(XRBaseInteractor interactor)
    {
        Debug.Log(gameObject.name + " Deactivated by:" + interactor.gameObject.name);
    }

}
