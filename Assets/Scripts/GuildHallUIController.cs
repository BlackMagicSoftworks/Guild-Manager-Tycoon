using System.Xml.Serialization;
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
    [SerializeField] private GameObject partyAssignmentPanel;
    
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
        partyAssignmentPanel.SetActive(false);
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

    public void OpenPartyAssignment()
    {
        acceptedContractDetailsPanel.SetActive(false);
        partyAssignmentPanel.SetActive(true);
    }

    public void BackPartyAssignmentPanel()
    {
        partyAssignmentPanel.SetActive(false);
        acceptedContractDetailsPanel.SetActive(true);
    }
}
