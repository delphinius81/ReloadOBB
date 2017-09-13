using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VR;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ReleadOBB {
   public class ReloadCallExample : MonoBehaviour {
      void Start() {
			// This calls the reload obb activity. You should call this from an applicable point in your code.
			// For example, the first time your application runs, or after retrieving the OBB file from GooglePlay.
			// It should only be called when running on device.
			#if UNITY_ANDROID && !UNITY_EDITOR
			CallReloadOBB.Reload();
			#endif
      }
   }
}