using UnityEngine;
using System;
public class door : MonoBehaviour
{
    #region "doorvar"
    [Header("materials")]
    [Tooltip("anything")]
    [SerializeField] private Material m_openmat;
    [SerializeField] private Material m_closemat;
    [SerializeField] private Material m_lockedmat;

    [Header("open/close")]
    [SerializeField] private MeshRenderer m_meshRenderer;
    [SerializeField] private Material m_opendoor;
    [SerializeField] private Material m_closeddoor;
    [SerializeField] private Collider m_collider;

    [Header("doorsettings")]
    [SerializeField] private DoorType m_doorState;

    [Header("Player")]
    [SerializeField] private PlayerMovement m_playerMovement;
    public enum DoorType
    {
        StateOpen, 
        StateClose,
        StateLocked,

    }

    
    #endregion

    private void Awake()
    {
        DoorSetUp();
    }

    void DoorSetUp()
    {

        switch (m_doorState)
        {
            case DoorType.StateOpen:
                m_meshRenderer.material = m_openmat;
                m_collider.isTrigger = true;
                m_collider.enabled = true;
                break;
               
            case DoorType.StateClose:
                m_meshRenderer.material = m_closemat;
                m_collider.isTrigger = false;
                m_collider.enabled = true;
                break;

            case DoorType.StateLocked:
                m_meshRenderer.material= m_lockedmat;
                m_collider.isTrigger = false;
                m_collider.enabled = true;
                break;

             





        }
    }
    private void Update()
    {
        if (m_playerMovement == null)
            return;
        if (m_playerMovement.HasKey && m_doorState == DoorType.StateLocked)
        {
            m_doorState = DoorType.StateOpen;
            DoorSetUp();
        }
            
    }






}




