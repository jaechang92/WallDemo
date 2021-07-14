using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public struct PlayerStats
    {
        public int speed;
        public int attack;
        public int rotSpeed;
    }

    public enum EnumPlayerStats
    {
        speed,
        attack,
        rotSpeed,
        max,
    }
    PlayerStats stats;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    //public int GetDataInt()
    //{

    //}

}
