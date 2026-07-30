using UnityEngine;

public class GuildHallUIController : MonoBehaviour
{
    [SerializeField] private GameObject contractsPanel;
    [SerializeField] private GameObject contractDetailsPanel;
    [SerializeField] private GameObject acceptedContractDetailsPanel;
    [SerializeField] private GameObject availableContractEntry;
    [SerializeField] private GameObject acceptedContractEntry;
    [SerializeField] private GameObject clipboardButton;
    [SerializeField] private GameObject acceptedContractsPanel;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenJobBoard()
    {
        contractsPanel.SetActive(true);
    }

    public void CloseJobBoard()
    {
        contractsPanel.SetActive(false);
        contractDetailsPanel.SetActive(false);
    }

    public void CloseAcceptedJobPanel()
    {
        acceptedContractsPanel.SetActive(false);
        acceptedContractDetailsPanel.SetActive(false);
    }

    public void ViewContractDetails()
    {
        contractDetailsPanel.SetActive(true);
    }

    public void ViewAcceptedContractDetails()
    {
        acceptedContractDetailsPanel.SetActive(true);
    }

    public void BackContractDetailsPanel()
    {
        contractDetailsPanel.SetActive(false);
    }

    public void BackAcceptedContractDetailsPanel()
    {
        acceptedContractDetailsPanel.SetActive(false);
    }
    
    public void AcceptedContract()
    {
        contractDetailsPanel.SetActive(false);
        availableContractEntry.SetActive(false);
        acceptedContractEntry.SetActive(true);
        clipboardButton.SetActive(true);
    }

    public void OpenAcceptedContracts()
    {
        acceptedContractsPanel.SetActive(true);
    }
}
