using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartStreamer : MonoBehaviour
{
    //public TMP_Text Text;
    public TMP_Text Text = null;
    [DllImport("WSAPlayer/ARM64/HL2RmStreamUnityPlugin", EntryPoint = "StringReturnAPI01", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static extern string StringReturnAPI01();

#if ENABLE_WINMD_SUPPORT
    [DllImport("HL2RmStreamUnityPlugin.dll", EntryPoint = "Initialize", CallingConvention = CallingConvention.StdCall)]
    public static extern void InitializeDll();
    

    
    
#endif

    // Start is called before the first frame update
    void Start()
    {
        Text.SetText("Test");
        string strReturn01 = StringReturnAPI01();
        Text.SetText(strReturn01);
#if ENABLE_WINMD_SUPPORT
        
        //Debug.Log("Returned string : " + strReturn01);
        //Debug.Log("TEST.");
        //Debug.Log("Initialization started.");

        //InitializeDll();

        

        
#endif
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
