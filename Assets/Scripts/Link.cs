using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link: MonoBehaviour
{
    public void openLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/company/roche/");
    }

    public void openInsta()
    {
        Application.OpenURL("https://www.instagram.com/roche/?hl=en");
    }

    public void openX()
    {
        Application.OpenURL("https://twitter.com/Roche?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor");
    }
    public void openARVR()
    {
        Application.OpenURL("https://assets.roche.com/f/174029/x/03386e3020/white-paper_future-lab-with-vr-and-simulation_hd-2.pdf");
    }
    public void openDA()
    {
        Application.OpenURL("https://www.roche.com/innovation/partnering/areas-of-interest/diagnostics-automation");
    }
}
