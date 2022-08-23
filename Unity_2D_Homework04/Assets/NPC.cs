using UnityEngine;
namespace LP
{
    public class NPC : MonoBehaviour
    {
        private void Start()
        {
            OpenStore();
        }
        private void Talk(string TalkContent)
        {

        }
        public bool OpenStore()
        {
            return true;
        }
        public int BuyItem(int OneHundred)
        {
            OneHundred = 100;
            return 0;
        }
        public void GetMission(int number)
        {

        }
        private int UpdateMission(int MissionItem)
        {
            return 0;
            MissionItem = 1;
        }
        private bool MissiomComplete(int number)
        {
            return false;
        }
    }
}

