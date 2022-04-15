using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class fishObject
{
        public string fishName;
        private string fishDesc;
        private int fishLvl;
        private Sprite icon;
        private Dictionary<string, int> fishStats;
        private Dictionary<string, float> statSpread;


        public fishObject(int fishID, string fishName, string fishDesc, int fishLvl, Dictionary<string, float> statSpread)
        {
            this.fishID = fishID;
            this.fishName = fishName;
            this.fishDesc = fishDesc;
            this.fishLvl = fishLvl;
            this.icon = Resources.Load<Sprite>("Sprites/Fish" + fishName);  
            //set stats and stat spread
            fishStats = new Dictionary<string, int>();
            this.statSpread = statSpread;
            updateStats();
        }

        private void updateStats()
        {
            //clear fishStats
            foreach(KeyValuePair<string, int> stat in fishStats)
            {
                fishStats.Remove(stat.Key);
            }
            
            //refill with appropriate stats
            foreach(KeyValuePair<string, float> spread in statSpread)
            {
                fishStats.Add(spread.Key, (int)Math.Round(spread.Value * 12.0 * fishLvl));
            }
        }


        private void printFish()
        {
            Debug.Log("ID: " + fishID.ToString());
            Debug.Log("Name: " + fishName);
            Debug.Log("Desc: " + fishDesc);
            Debug.Log("Level: " + fishLvl.ToString());
            Debug.Log("Stat spread: " + statSpread.ToString());
        }
       

    }



