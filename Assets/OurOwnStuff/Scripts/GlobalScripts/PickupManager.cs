﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    public static PickupManager instance;
    List<IPickUp> pickUps = new List<IPickUp>();

    private void Awake()
    {
        //Check if gamemanager already exists
        if (instance == null)

            //if not, set gamemanager to this
            instance = this;

        //If gamemanager already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

    }

    public void AddListener(IPickUp pickUp)
    {
        pickUps.Add(pickUp);
    }

    public void ItemWasPickedUp(GameObject _picked)
    {
        foreach (IPickUp listener in pickUps)
        {
            listener.PickedUp(_picked);
        }
    }

    public void ItemWasDropped(GameObject _droped)
    {
        foreach (IPickUp listener in pickUps)
        {
            listener.Droped(_droped);
        }
    }


}

public interface IPickUp
{
    void PickedUp(GameObject _pickedObject);

    void Droped(GameObject _droped);
}
