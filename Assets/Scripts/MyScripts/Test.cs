using System.Diagnostics;
using MemoryPack;
using MessagePack;
using UnityEngine;
using Debug = UnityEngine.Debug;
// ReSharper disable InconsistentNaming

namespace MyScripts
{
    public class Test
    {
        [RuntimeInitializeOnLoadMethod]
        private static void TestMethod()
        {
        
            #region MemoryPack

            Stopwatch memoryWatch = new Stopwatch();
            var v_m = new PersonMemoryPack { Age = 40, Name = "John" };
            memoryWatch.Start();
            var bin_m = MemoryPackSerializer.Serialize(v_m);
            var val_m = MemoryPackSerializer.Deserialize<PersonMemoryPack>(bin_m);
            memoryWatch.Stop();
        
            #endregion
        
            #region MessagePack

            Stopwatch messageWatch = new Stopwatch();
            var v_message = new PersonMessagePack() { Age = 40, Name = "John" };
            messageWatch.Start();
            var bin_message = MessagePackSerializer.Serialize(v_message);
            var val_message = MessagePackSerializer.Deserialize<PersonMessagePack>(bin_message);
            messageWatch.Stop();
        
            #endregion

            #region UnityFormatter

            Stopwatch unityWatch = new Stopwatch();
            var v_u = new PersonUnityFormatter() { age = 40, name = "John" };
            unityWatch.Start();
            var bin_u = JsonUtility.ToJson(v_u);
            var val_u = JsonUtility.FromJson<PersonUnityFormatter>(bin_u);
            unityWatch.Stop();
        
            #endregion

            #region Result

            Debug.Log($"MemoryPack:{memoryWatch.Elapsed}");
        
            Debug.Log($"MessagePack:{messageWatch.Elapsed}");

            Debug.Log($"JsonUtility{unityWatch.Elapsed}");
        
            #endregion
        }
    }
}
