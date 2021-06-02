using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{

    public class SaveLoadSystem : MonoBehaviour
    {
        private string FilePath => Application.streamingAssetsPath + "/gameData";

        [SerializeField] private GameData gameData = new GameData();

        private void Start()
        {
            if (!Directory.Exists(Application.streamingAssetsPath))
                Directory.CreateDirectory(Application.streamingAssetsPath);
        }

        void Save()
        {
           SaveBinary();
            
        }

        private void SaveBinary()
        {
            // This opens the 'river' between the RAM and the file.
            using (FileStream stream = new FileStream(FilePath + "_save", FileMode.OpenOrCreate))
            {
                // Like creating the boat that will carry the data from one point to another
                BinaryFormatter formatter = new BinaryFormatter();
                // Transports the data from the sum to the specified file, like freezing water
                // into ice.
                formatter.Serialize(stream, gameData);

            }
        }

        void Load()
        {
           LoadBinary();
        }

        private void LoadBinary()
        {
            // If there is no save data, we shoudn't attempt to load it
            if (File.Exists(FilePath + ".save"))
                return;
            // This opens the 'river' between the RAM and the file.
            using (FileStream stream = new FileStream(FilePath + "_save", FileMode.Open))
            {
                // Like creating the boat that will carry the data from one point to another
                BinaryFormatter formatter = new BinaryFormatter();
                // Transports the data from the sum to the specified file to the RAM, like freezing water
                // into ice.
                gameData = formatter.Deserialize(stream) as GameData;

            }
        }




        private void OnGUI()
        {
            if (GUILayout.Button("Save"))
            {
                // Do that save thing you've been talking about
                Save();
            }
            if (GUILayout.Button("Load"))
            {
                // Do that load thing you've been talking about
                Load();
            }
        }
    }
}