using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkOpen : MonoBehaviour
{

    public void LinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/manjit-majhi/");
    }
    public void Github()
    {
        Application.OpenURL("https://github.com/manjit-hub");
    }
    public void LeetCode()
    {
        Application.OpenURL("https://leetcode.com/manjit-code/");
    }
    public void Hashnode()
    {
        Application.OpenURL("https://hashnode.com/@manjitnode");
    }
    public void CV()
    {
        Application.OpenURL("https://drive.google.com/file/d/1rEtGQeRaf7pJBUC_YZUXqgmPshtpREIU/view?usp=sharing");
    }

    private bool isPaused = false;
    private bool isRunning = true;

   
}
