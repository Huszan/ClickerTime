using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void Save(Helper help)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/savefile.gut";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveState data = new SaveState(help);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SaveState Load()
    {
        string path = Application.persistentDataPath + "/savefile.gut";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveState data = formatter.Deserialize(stream) as SaveState;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

}
