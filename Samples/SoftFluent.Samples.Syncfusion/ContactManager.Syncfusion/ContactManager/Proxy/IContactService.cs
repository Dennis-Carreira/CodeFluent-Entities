﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactManager.Proxy
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Wednesday, 12 February 2014 15:18.
    // Build:1.0.61214.0762
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0762")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.mycie.com/contactmanager/contactmanager")]
    public partial interface IContactService
    {
        
        [System.ServiceModel.OperationContractAttribute()]
        string Validate(ContactManager.Proxy.Contact contact, string culture);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool Delete(ContactManager.Proxy.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute()]
        ContactManager.Proxy.Contact Load(int id);
        
        [System.ServiceModel.OperationContractAttribute()]
        ContactManager.Proxy.Contact LoadByEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool Save(ContactManager.Proxy.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool SaveByRef(ref ContactManager.Proxy.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute()]
        ContactManager.Proxy.Contact LoadByEntityKey(string key);
        
        [System.ServiceModel.OperationContractAttribute()]
        bool DeleteByKey(int id);
        
        [System.ServiceModel.OperationContractAttribute()]
        void SaveAll(ContactManager.Proxy.ContactCollection contactCollection);
        
        [System.ServiceModel.OperationContractAttribute()]
        ContactManager.Proxy.ContactCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions);
        
        [System.ServiceModel.OperationContractAttribute()]
        ContactManager.Proxy.ContactCollection LoadAll();
    }
}
