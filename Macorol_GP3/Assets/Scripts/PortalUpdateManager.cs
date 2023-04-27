using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalUpdateManager : MonoBehaviour
{
    public GameObject Axe, Knife;

    private void OnEnable()
    {
        EventsManager.onAxePortal += AxeEnabled;
        EventsManager.onKnifePortal += KnifeEnabled;
    }

    private void KnifeEnabled()
    {
        Knife.SetActive(true);
        Axe.SetActive(false);
    }

    private void AxeEnabled()
    {
        Axe.SetActive(true);
        Knife.SetActive(false);
    }
}
