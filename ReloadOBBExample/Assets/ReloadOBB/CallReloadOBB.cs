using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallReloadOBB {
   public static void Reload()
   {
      using (AndroidJavaClass unity_player = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
      {
         AndroidJavaObject current_activity = unity_player.GetStatic<AndroidJavaObject>("currentActivity");
         Debug.Log("Attempting to launch external reload activity.");
         var jc = new AndroidJavaClass("com.delphinius81.reloadobb.ReloadObbActivity");
         //jc.CallStatic("Launch", current_activity);
         jc.Call("Launch", current_activity);
      }
   }
}
