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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04", IsNullable=false)]
public partial class Document {
    
    private SubscriptionBulkOrderCancellationRequestV04 sbcptBlkOrdrCxlReqField;
    
    /// <remarks/>
    public SubscriptionBulkOrderCancellationRequestV04 SbcptBlkOrdrCxlReq {
        get {
            return this.sbcptBlkOrdrCxlReqField;
        }
        set {
            this.sbcptBlkOrdrCxlReqField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class SubscriptionBulkOrderCancellationRequestV04 {
    
    private MessageIdentification1 msgIdField;
    
    private AdditionalReference9 poolRefField;
    
    private AdditionalReference8 prvsRefField;
    
    private string mstrRefField;
    
    private InvestmentFundOrder9[] ordrRefsField;
    
    private CopyInformation4 cpyDtlsField;
    
    /// <remarks/>
    public MessageIdentification1 MsgId {
        get {
            return this.msgIdField;
        }
        set {
            this.msgIdField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference9 PoolRef {
        get {
            return this.poolRefField;
        }
        set {
            this.poolRefField = value;
        }
    }
    
    /// <remarks/>
    public AdditionalReference8 PrvsRef {
        get {
            return this.prvsRefField;
        }
        set {
            this.prvsRefField = value;
        }
    }
    
    /// <remarks/>
    public string MstrRef {
        get {
            return this.mstrRefField;
        }
        set {
            this.mstrRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OrdrRefs")]
    public InvestmentFundOrder9[] OrdrRefs {
        get {
            return this.ordrRefsField;
        }
        set {
            this.ordrRefsField = value;
        }
    }
    
    /// <remarks/>
    public CopyInformation4 CpyDtls {
        get {
            return this.cpyDtlsField;
        }
        set {
            this.cpyDtlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class CopyInformation4 {
    
    private bool cpyIndField;
    
    private string orgnlRcvrField;
    
    /// <remarks/>
    public bool CpyInd {
        get {
            return this.cpyIndField;
        }
        set {
            this.cpyIndField = value;
        }
    }
    
    /// <remarks/>
    public string OrgnlRcvr {
        get {
            return this.orgnlRcvrField;
        }
        set {
            this.orgnlRcvrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class GenericIdentification30 {
    
    private string idField;
    
    private string issrField;
    
    private string schmeNmField;
    
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
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
    
    /// <remarks/>
    public string SchmeNm {
        get {
            return this.schmeNmField;
        }
        set {
            this.schmeNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class CancellationReason32Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification30))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class InvestmentFundOrder9 {
    
    private string ordrRefField;
    
    private string clntRefField;
    
    private string cxlRefField;
    
    private CancellationReason32Choice cxlRsnField;
    
    /// <remarks/>
    public string OrdrRef {
        get {
            return this.ordrRefField;
        }
        set {
            this.ordrRefField = value;
        }
    }
    
    /// <remarks/>
    public string ClntRef {
        get {
            return this.clntRefField;
        }
        set {
            this.clntRefField = value;
        }
    }
    
    /// <remarks/>
    public string CxlRef {
        get {
            return this.cxlRefField;
        }
        set {
            this.cxlRefField = value;
        }
    }
    
    /// <remarks/>
    public CancellationReason32Choice CxlRsn {
        get {
            return this.cxlRsnField;
        }
        set {
            this.cxlRsnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class AdditionalReference8 {
    
    private string refField;
    
    private PartyIdentification113 refIssrField;
    
    private string msgNmField;
    
    /// <remarks/>
    public string Ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification113 RefIssr {
        get {
            return this.refIssrField;
        }
        set {
            this.refIssrField = value;
        }
    }
    
    /// <remarks/>
    public string MsgNm {
        get {
            return this.msgNmField;
        }
        set {
            this.msgNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class PartyIdentification113 {
    
    private PartyIdentification90Choice ptyField;
    
    private string lEIField;
    
    /// <remarks/>
    public PartyIdentification90Choice Pty {
        get {
            return this.ptyField;
        }
        set {
            this.ptyField = value;
        }
    }
    
    /// <remarks/>
    public string LEI {
        get {
            return this.lEIField;
        }
        set {
            this.lEIField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class PartyIdentification90Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification1))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class NameAndAddress5 {
    
    private string nmField;
    
    private PostalAddress1 adrField;
    
    /// <remarks/>
    public string Nm {
        get {
            return this.nmField;
        }
        set {
            this.nmField = value;
        }
    }
    
    /// <remarks/>
    public PostalAddress1 Adr {
        get {
            return this.adrField;
        }
        set {
            this.adrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class PostalAddress1 {
    
    private AddressType2Code adrTpField;
    
    private bool adrTpFieldSpecified;
    
    private string[] adrLineField;
    
    private string strtNmField;
    
    private string bldgNbField;
    
    private string pstCdField;
    
    private string twnNmField;
    
    private string ctrySubDvsnField;
    
    private string ctryField;
    
    /// <remarks/>
    public AddressType2Code AdrTp {
        get {
            return this.adrTpField;
        }
        set {
            this.adrTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdrTpSpecified {
        get {
            return this.adrTpFieldSpecified;
        }
        set {
            this.adrTpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
    public string[] AdrLine {
        get {
            return this.adrLineField;
        }
        set {
            this.adrLineField = value;
        }
    }
    
    /// <remarks/>
    public string StrtNm {
        get {
            return this.strtNmField;
        }
        set {
            this.strtNmField = value;
        }
    }
    
    /// <remarks/>
    public string BldgNb {
        get {
            return this.bldgNbField;
        }
        set {
            this.bldgNbField = value;
        }
    }
    
    /// <remarks/>
    public string PstCd {
        get {
            return this.pstCdField;
        }
        set {
            this.pstCdField = value;
        }
    }
    
    /// <remarks/>
    public string TwnNm {
        get {
            return this.twnNmField;
        }
        set {
            this.twnNmField = value;
        }
    }
    
    /// <remarks/>
    public string CtrySubDvsn {
        get {
            return this.ctrySubDvsnField;
        }
        set {
            this.ctrySubDvsnField = value;
        }
    }
    
    /// <remarks/>
    public string Ctry {
        get {
            return this.ctryField;
        }
        set {
            this.ctryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public enum AddressType2Code {
    
    /// <remarks/>
    ADDR,
    
    /// <remarks/>
    PBOX,
    
    /// <remarks/>
    HOME,
    
    /// <remarks/>
    BIZZ,
    
    /// <remarks/>
    MLTO,
    
    /// <remarks/>
    DLVY,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class GenericIdentification1 {
    
    private string idField;
    
    private string schmeNmField;
    
    private string issrField;
    
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
    public string SchmeNm {
        get {
            return this.schmeNmField;
        }
        set {
            this.schmeNmField = value;
        }
    }
    
    /// <remarks/>
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.008.001.04")]
public partial class AdditionalReference9 {
    
    private string refField;
    
    private PartyIdentification113 refIssrField;
    
    private string msgNmField;
    
    /// <remarks/>
    public string Ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification113 RefIssr {
        get {
            return this.refIssrField;
        }
        set {
            this.refIssrField = value;
        }
    }
    
    /// <remarks/>
    public string MsgNm {
        get {
            return this.msgNmField;
        }
        set {
            this.msgNmField = value;
        }
    }
}
