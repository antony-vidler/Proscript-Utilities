using System;
using System.Xml;

namespace XmlDateAmendment
{
    public class MainForm
    {
        // Method to update AppTransID
        public void UpdateAppTransID(XmlDocument xmlDoc, string newAppTransID)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsmgr.AddNamespace("ns", "http://example.com/ns"); // Replace with the actual namespace
            
            XmlNode appTransIDNode = xmlDoc.SelectSingleNode("//ns:AppTransID", nsmgr);
            if (appTransIDNode != null)
            {
                appTransIDNode.InnerText = newAppTransID;
            }
        }

        // Method to update AppTransDateTime
        public void UpdateAppTransDateTime(XmlDocument xmlDoc, DateTime newDateTime)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsmgr.AddNamespace("ns", "http://example.com/ns"); // Replace with actual namespace
            
            XmlNode appTransDateTimeNode = xmlDoc.SelectSingleNode("//ns:AppTransDateTime", nsmgr);
            if (appTransDateTimeNode != null)
            {
                appTransDateTimeNode.InnerText = newDateTime.ToString("o"); // ISO 8601 format
            }
        }

        // Method to update PrescriptionDateTime
        public void UpdatePrescriptionDateTime(XmlDocument xmlDoc, DateTime newDateTime)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsmgr.AddNamespace("ns", "http://example.com/ns"); // Replace with actual namespace
            
            XmlNode prescriptionDateTimeNode = xmlDoc.SelectSingleNode("//ns:PrescriptionDateTime", nsmgr);
            if (prescriptionDateTimeNode != null)
            {
                prescriptionDateTimeNode.InnerText = newDateTime.ToString("o"); // ISO 8601 format
            }
        }

        // Method to update MedicationStartDate
        public void UpdateMedicationStartDate(XmlDocument xmlDoc, DateTime newStartDate)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsmgr.AddNamespace("ns", "http://example.com/ns"); // Replace with actual namespace
            
            XmlNode medicationStartDateNode = xmlDoc.SelectSingleNode("//ns:MedicationStartDate", nsmgr);
            if (medicationStartDateNode != null)
            {
                medicationStartDateNode.InnerText = newStartDate.ToString("o"); // ISO 8601 format
            }
        }
    }
}