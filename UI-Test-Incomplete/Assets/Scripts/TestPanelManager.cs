using UnityEngine;

public class TestPanelManager : MonoBehaviour
{
    public GameObject testPanel;
    public GameObject openButton;
    public GameObject closeButton;

    public GameObject ThrowablePanel;
    

    public void OpenTestPanel()
    {
        testPanel.SetActive(true);
        openButton.SetActive(false);
        closeButton.SetActive(true);
        ThrowablePanel.SetActive(false);
    }


    public void CloseTestPanel()
    {
        testPanel.SetActive(false);
        openButton.SetActive(true);
        closeButton.SetActive(false);
        ThrowablePanel.SetActive(true);
    }
}
