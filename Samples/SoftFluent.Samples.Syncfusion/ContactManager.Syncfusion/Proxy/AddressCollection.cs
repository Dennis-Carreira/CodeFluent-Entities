﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactManager.Proxy
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Thursday, 13 February 2014 19:31.
    // Build:1.0.61214.0762
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0762")]
    [System.ComponentModel.DataObjectAttribute()]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.CollectionTypeConverter))]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Namespace="http://schemas.contactmanager.com", ItemName="Address")]
    public partial class AddressCollection : CodeFluent.Runtime.ServiceModel.CodeFluentEntityList<ContactManager.Proxy.Address>, CodeFluent.Runtime.ServiceModel.ICodeFluentSet, CodeFluent.Runtime.Diagnostics.ITraceable
    {
        
        [System.NonSerializedAttribute()]
        private System.Collections.Hashtable _relations = new System.Collections.Hashtable();
        
        public AddressCollection()
        {
        }
        
        public AddressCollection(string contextName, System.ServiceModel.Channels.IChannel channel, string pageMethodName, CodeFluent.Runtime.PageOptions pageOptions, params object[] arguments) : 
                base(contextName, channel, pageMethodName, pageOptions, arguments)
        {
        }
        
        System.Collections.IDictionary CodeFluent.Runtime.ServiceModel.ICodeFluentSet.Relations
        {
            get
            {
                return this._relations;
            }
        }
        
        public virtual void SaveAll()
        {
            ContactManager.Proxy.AddressCollection changed = new ContactManager.Proxy.AddressCollection();
            this.FindAllPending(changed);
            if ((changed.Count <= 0))
            {
                return;
            }
            ContactManager.Proxy.Address.WcfClient.Current.Channel.SaveAll(changed);
            this.Commit();
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static ContactManager.Proxy.AddressCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions)
        {
            ContactManager.Proxy.AddressCollection collection = ContactManager.Proxy.Address.WcfClient.Current.Channel.PageLoadAll(pageIndex, pageSize, pageOptions);
            return collection;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static ContactManager.Proxy.AddressCollection LoadAll()
        {
            ContactManager.Proxy.AddressCollection collection = new ContactManager.Proxy.AddressCollection(ContactManager.Proxy.Constants.ContactManagerStoreName, ((System.ServiceModel.Channels.IChannel)(ContactManager.Proxy.Address.WcfClient.Current.Channel)), "PageLoadAll", null);
            collection.LoadKnownItems();
            return collection;
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write(string.Concat("Count=", this.Count));
            writer.Write("]");
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.Diagnostics.ITraceable.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(ContactManager.Proxy.Address address)
        {
            if ((address == null))
            {
                return false;
            }
            return address.Save();
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(ContactManager.Proxy.Address address)
        {
            if ((address == null))
            {
                return false;
            }
            return address.Delete();
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(ContactManager.Proxy.Address address)
        {
            if ((address == null))
            {
                return false;
            }
            return address.Save();
        }
        
        public override void Add(ContactManager.Proxy.Address item)
        {
            base.Add(item);
        }
        
        public override void Insert(int index, ContactManager.Proxy.Address item)
        {
            base.Insert(index, item);
        }
        
        public override bool Remove(ContactManager.Proxy.Address item)
        {
            bool ret = base.Remove(item);
            return ret;
        }
        
        protected virtual void Relate(ContactManager.Proxy.Address item, CodeFluent.Runtime.CodeFluentRelationType relationType)
        {
            ((CodeFluent.Runtime.ServiceModel.ICodeFluentSet)(this)).Relations[item] = relationType;
        }
        
        public new virtual ContactManager.Proxy.AddressCollection Clone(bool deep)
        {
            ContactManager.Proxy.AddressCollection ret = new ContactManager.Proxy.AddressCollection();
            this.CopyTo(ret, deep);
            return ret;
        }
        
        protected override string GetUserMessage(System.Globalization.CultureInfo culture, CodeFluent.Runtime.UserExceptionType type, string name, object[] args)
        {
            return ContactManager.Proxy.Resources.Manager.GetUserMessage(culture, type, name, args);
        }
    }
}