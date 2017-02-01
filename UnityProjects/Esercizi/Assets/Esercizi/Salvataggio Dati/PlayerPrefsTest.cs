#define MY_DEBUG

using UnityEngine;

namespace Files
{
    public class PlayerPrefsTest : MonoBehaviour
    {
        private int selectedProfiledID;

        private const string SELECTED_PROFILE_ID_KEY = "selected_profile_id";

        private void Start()
        {
            selectedProfiledID = PlayerPrefs.GetInt(SELECTED_PROFILE_ID_KEY, 1); // Se non esiste, ritorna di default 1

            Debug.Log("Welcome player " + selectedProfiledID + "!");
        }

        private void Update()
        {
            //throw new System.Exception("Ciao");

            if (Input.GetKeyDown(KeyCode.Alpha1) && selectedProfiledID != 1)
            {
                selectedProfiledID = 1;
                Debug.Log("Switching to profile " + selectedProfiledID);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2) && selectedProfiledID != 2)
            {
                selectedProfiledID = 2;
                Debug.Log("Switching to profile " + selectedProfiledID);
            }

            if (Input.GetKeyDown(KeyCode.Alpha3) && selectedProfiledID != 3)
            {
                selectedProfiledID = 3;
                Debug.Log("Switching to profile " + selectedProfiledID);
            }

            if (Input.GetKeyDown(KeyCode.Alpha4) && selectedProfiledID != 4)
            {
                selectedProfiledID = 4;
                Debug.Log("Switching to profile " + selectedProfiledID);
            }
        }

        // Viene chiamato quando viene chiusa l'applicazione su ogni monobehaviour che ha il metodo
        private void OnApplicationQuit()
        {
            if (PlayerPrefs.HasKey(SELECTED_PROFILE_ID_KEY))
            {
                int currentSavedPlayerProfileID = PlayerPrefs.GetInt(SELECTED_PROFILE_ID_KEY);

                if (selectedProfiledID != currentSavedPlayerProfileID)
                {
                    PlayerPrefs.SetInt(SELECTED_PROFILE_ID_KEY, selectedProfiledID);
                    PlayerPrefs.Save();
                }
            }

            else
            {
                PlayerPrefs.SetInt(SELECTED_PROFILE_ID_KEY, selectedProfiledID);
                PlayerPrefs.Save();
            }
        }
        
        // Sono due metodi di definire logica condizionale
        private static void MyLog_1(string logstring)
        {
#if MY_DEBUG
            Debug.Log(logstring);
#endif
        }

        [System.Diagnostics.Conditional("MY_DEBUG")]
        private static void MyLog_2(string logstring)
        {
            Debug.Log(logstring);
        }
    }
}