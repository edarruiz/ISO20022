﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.035.001.03")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.035.001.03", IsNullable=false)]
public partial class Document {
    
    private StatusExtensionRequestV03 stsXtnsnReqField;
    
    /// <remarks/>
    public StatusExtensionRequestV03 StsXtnsnReq {
        get {
            return this.stsXtnsnReqField;
        }
        set {
            this.stsXtnsnReqField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.035.001.03")]
public partial class StatusExtensionRequestV03 {
    
    private MessageIdentification1 reqIdField;
    
    private SimpleIdentificationInformation txIdField;
    
    private SimpleIdentificationInformation submitrTxRefField;
    
    private TransactionStatus5 stsToBeXtndedField;
    
    /// <remarks/>
    public MessageIdentification1 ReqId {
        get {
            return this.reqIdField;
        }
        set {
            this.reqIdField = value;
        }
    }
    
    /// <remarks/>
    public SimpleIdentificationInformation TxId {
        get {
            return this.txIdField;
        }
        set {
            this.txIdField = value;
        }
    }
    
    /// <remarks/>
    public SimpleIdentificationInformation SubmitrTxRef {
        get {
            return this.submitrTxRefField;
        }
        set {
            this.submitrTxRefField = value;
        }
    }
    
    /// <remarks/>
    public TransactionStatus5 StsToBeXtnded {
        get {
            return this.stsToBeXtndedField;
        }
        set {
            this.stsToBeXtndedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.035.001.03")]
public partial class MessageIdentification1 {
    
    private string idField;
    
    private System.DateTime creDtTmField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime CreDtTm {
        get {
            return this.creDtTmField;
        }
        set {
            this.creDtTmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.035.001.03")]
public partial class TransactionStatus5 {
    
    private BaselineStatus3Code stsField;
    
    private System.DateTime chngDtTmField;
    
    private string descField;
    
    /// <remarks/>
    public BaselineStatus3Code Sts {
        get {
            return this.stsField;
        }
        set {
            this.stsField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime ChngDtTm {
        get {
            return this.chngDtTmField;
        }
        set {
            this.chngDtTmField = value;
        }
    }
    
    /// <remarks/>
    public string Desc {
        get {
            return this.descField;
        }
        set {
            this.descField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.035.001.03")]
public enum BaselineStatus3Code {
    
    /// <remarks/>
    PROP,
    
    /// <remarks/>
    CLSD,
    
    /// <remarks/>
    PMTC,
    
    /// <remarks/>
    ESTD,
    
    /// <remarks/>
    ACTV,
    
    /// <remarks/>
    COMP,
    
    /// <remarks/>
    AMRQ,
    
    /// <remarks/>
    RARQ,
    
    /// <remarks/>
    CLRQ,
    
    /// <remarks/>
    SCRQ,
    
    /// <remarks/>
    SERQ,
    
    /// <remarks/>
    DARQ,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.035.001.03")]
public partial class SimpleIdentificationInformation {
    
    private string idField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}
