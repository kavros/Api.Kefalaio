//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace MyData.Xsd
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [SerializableAttribute()]
    [XmlTypeAttribute("PaymentMethodType", Namespace="https://www.aade.gr/myDATA/paymentMethod/v1.0")]
    public partial class PaymentMethodType
    {
        
        /// <summary>
        /// <para>Μοναδικός Αριθμός Καταχώρησης Παραστατικού</para>
        /// </summary>
        [DescriptionAttribute("Μοναδικός Αριθμός Καταχώρησης Παραστατικού")]
        [RequiredAttribute()]
        [XmlElementAttribute("invoiceMark")]
        public long invoiceMark { get; set; }
        
        /// <summary>
        /// <para>Αποδεικτικό Λήψης Τρόπων Πληρωμής. Συμπληρώνεται από την Υπηρεσία</para>
        /// </summary>
        [DescriptionAttribute("Αποδεικτικό Λήψης Τρόπων Πληρωμής. Συμπληρώνεται από την Υπηρεσία")]
        [XmlElementAttribute("paymentMethodMark")]
        public Nullable<long> paymentMethodMark { get; set; }
        
        /// <summary>
        /// <para>ΑΦΜ Οντότητας Αναφοράς</para>
        /// </summary>
        [DescriptionAttribute("ΑΦΜ Οντότητας Αναφοράς")]
        [XmlElementAttribute("entityVatNumber")]
        public string entityVatNumber { get; set; }
        
        [RequiredAttribute()]
        [XmlElementAttribute("paymentMethodDetails")]
        public List<MyData.Xsd.PaymentMethodDetailType> paymentMethodDetails { get; set; }
    }
}